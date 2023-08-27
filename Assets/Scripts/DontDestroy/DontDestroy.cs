using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
    private void Awake()
    {
        if(File.Exists(GameManager.path))
        {
            GameManager.LOAD();
        }

        DontDestroyOnLoad(gameObject);

        SceneManager.LoadScene("Begin");
    }
}
