using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBarController : MonoBehaviour
{
    public Image progressbarImage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (progressbarImage!=null)
        {
            progressbarImage.fillAmount = SceneLoader.GetLoadingProgress();
        }
        else
        {
            Debug.Log("Progressbar Image in Progressbar controller is set to null");
        }
    }
}
