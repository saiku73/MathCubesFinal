using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
public void OnPlayClicked()
    {
        SceneLoader.LoadScene(SceneLoader.SceneIndex.GameScene);
    }
}
