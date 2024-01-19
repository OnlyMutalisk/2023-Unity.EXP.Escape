using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class DontDestroy : MonoBehaviour
{
    public GameObject loading;

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
