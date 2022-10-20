using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader Instance;
    public static Action onLoaderCallback;
    private static AsyncOperation asyncOp;
    private class LoadingMonobehavior : MonoBehaviour { };
    public enum SceneIndex
    {
        MainMenu,
        Loading,
        GameScene
    }
    private void Awake()
    {
        Instance = this;
    }
    public static void LoadScene(SceneIndex sceneIndex)
    {

        onLoaderCallback = () =>
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(sceneIndex.ToString());
            };

        //UnityEngine.SceneManagement.SceneManager.LoadScene(SceneIndex.Loading.ToString());
        GameObject loadingGameobject = new GameObject("Dummy Object to hold the co-routine call");
        loadingGameobject.AddComponent<LoadingMonobehavior>().StartCoroutine(LoadSceneAsync(sceneIndex));

        SceneManager.LoadScene(SceneIndex.Loading.ToString());
    }
    public static IEnumerator LoadSceneAsync(SceneIndex sceneIndex)
    {
        yield return null;
        asyncOp = SceneManager.LoadSceneAsync(sceneIndex.ToString());
        while (!asyncOp.isDone)
        {
            yield return null;
        }
    }
    public static float GetLoadingProgress()
    {
        if (asyncOp != null)
        {
            return asyncOp.progress;
        }
        else
        {
            return 1f;
        }
    }
    public static void LoaderCallback()
    {
        if (onLoaderCallback != null)
        {
            onLoaderCallback();
            onLoaderCallback = null;
        }
    }
}
