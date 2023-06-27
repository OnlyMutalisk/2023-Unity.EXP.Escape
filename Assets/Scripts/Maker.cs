using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Maker : MonoBehaviour
{
    /// <summary>
    /// 지정 씬으로 넘어갑니다.</br>
    /// </summary>
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
