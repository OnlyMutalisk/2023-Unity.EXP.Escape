using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MakerButton : MonoBehaviour
{
    /// <summary>
    /// <br>Maker 씬으로 넘깁니다.</br>
    /// </summary>
    public void ChangeScene()
    {
        SceneManager.LoadScene("Maker");
    }
}
