using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Begin : MonoBehaviour
{
    public GameObject confirmation;

    /// <summary>
    /// <br>확인 창을 팝업 합니다.</br>
    /// </summary>
    public void OpenConfirmation()
    {
        confirmation.SetActive(true);
    }

    /// <summary>
    /// <br>확인 창을 닫습니다.</br>
    /// </summary>
    public void CloseConfirmation()
    {
        confirmation.SetActive(false);
    }

    /// <summary>
    /// 지정 씬으로 넘어갑니다.</br>
    /// </summary>
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    /// <summary>
    /// <br>게임을 종료합니다.</br>
    /// </summary>
    public void ExitGame()
    {
        Application.Quit();
    }
}