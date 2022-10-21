using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[AddComponentMenu("SvanGames/Services/logging")]
public class Logger : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] 
    bool showLogs;
    [SerializeField]
    Color logColor;
    public void Log(object message, Object sender)
    {
        string msg = message.ToString();
        if (showLogs)
        {
            if (logColor !=null)
            {
                //<color=red>message </color>AssetBundle not found"
                msg = "<color=#" + ColorUtility.ToHtmlStringRGB(logColor) + ">" + message.ToString() + "</color>";

            }
            Debug.Log(msg, sender);
        }
    }
}

