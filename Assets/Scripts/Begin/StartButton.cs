using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    /// <summary>
    /// <br>확인 창을 팝업 합니다.</br>
    /// </summary>
    public void OpenConfirmation()
    {
        transform.Find("Confirmation").gameObject.SetActive(true);
    }

    /// <summary>
    /// <br>확인 창을 닫습니다.</br>
    /// </summary>
    public void CloseConfirmation()
    {
        transform.Find("Confirmation").gameObject.SetActive(false);
    }

    /// <summary>
    /// <br>맵 0 시작 씬으로 넘어갑니다.</br>
    /// </summary>
    /// <param name="sceneName"></param>
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}