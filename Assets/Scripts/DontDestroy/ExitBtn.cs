using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitBtn : MonoBehaviour
{
    public GameObject menu;

    // 종료하기 버튼을 눌렀을 시 시작 화면으로 가거나, 이미 시작화면이라면 게임을 종료합니다.
    public void ChangeScene()
    {
        if (SceneManager.GetActiveScene().name == "Begin")
        {
            menu.SetActive(false);
            Application.Quit();
        }
        else
        {
            SceneManager.LoadScene("Begin");
            menu.SetActive(false);
            Room.BGM_재생("lobby");
            GameManager.SAVE();
        }
    }
}
