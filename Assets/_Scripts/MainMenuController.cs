using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{

    [SerializeField]
    Logger logger;
public void OnPlayClicked()
    {
        logger.Log("On Play Clicked", this);
        SceneLoader.LoadScene(SceneLoader.SceneIndex.GameScene);

    }
}
