using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public static SceneManager Instance;
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
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneIndex.ToString());
    }
}
