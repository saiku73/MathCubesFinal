using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingSceneCalllbackController : MonoBehaviour
{
    bool isFirstUpdate = true;
    // Update is called once per frame
    void Update()
    {
        if (isFirstUpdate==true)
        {
            isFirstUpdate = false;
            SceneLoader.LoaderCallback();

        }
    }
}
