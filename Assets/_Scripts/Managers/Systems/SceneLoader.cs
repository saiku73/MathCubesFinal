using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader Instance;
    public static Action onLoaderCallback;
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

        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneIndex.Loading.ToString());
    }

    public static void LoaderCallback()
    {
        if (onLoaderCallback!=null)
        {
            onLoaderCallback();
            onLoaderCallback = null;
        }
    }   
}
