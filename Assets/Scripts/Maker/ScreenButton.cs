using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenButton : MonoBehaviour
{
    /// <summary>
    /// <br>시작 화면으로 되돌아 갑니다.</br>
    /// </summary>
    public void ChangeScene()
    {
        SceneManager.LoadScene("Begin");
    }
}
