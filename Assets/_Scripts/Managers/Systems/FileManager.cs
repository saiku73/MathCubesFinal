using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FileManager : MonoBehaviour
{
    public static FileManager Instance;

    private void Awake()
    {
        Instance = this;
    }
}
