using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Begin : MonoBehaviour
{
    public GameObject confirmation;
    public GameObject alert;

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
    /// <br>게임을 시작합니다.</br>
    /// </summary>
    public void YesButton()
    {
        GameManager.RESET();
        GameManager.SAVE();
        SceneManager.LoadScene("map0_시작");
    }

    /// <summary>
    /// <br>메뉴의 On / Off 상태를 변환합니다.</br>
    /// </summary>
    public void MenuOnOffControl()
    {
        GameObject gameObjectMenu = GameObject.Find("CanvasDontDestroy").transform.GetChild(0).gameObject;

        // 메뉴가 켜져 있다면
        if (gameObjectMenu.active)
        {
            // 메뉴를 끕니다.
            gameObjectMenu.SetActive(false);
        }
        // 메뉴가 꺼져 있다면
        else
        {
            // 메뉴를 켭니다.
            gameObjectMenu.SetActive(true);
        }
    }

    /// <summary>
    /// <br>마지막 진행상황을 불러옵니다.</br>
    /// </summary>
    public void ContinueButton()
    {
        // 이전에 저장한 데이터가 있다면 이어서 하기
        if (GameManager.sceneName != null)
        {
            SceneManager.LoadScene(GameManager.sceneName);
            Room.BGM_재생("map" + GameManager.map.ToString());

            // 만약 남은시간이 매우 적다면, N초로 시작
            if (GameManager.gameTime[GameManager.map] <= GameManager.thresholdTime)
            {
                GameManager.gameTime[GameManager.map] = GameManager.finalTime;
            }

            GameTimer.TimerOn();
            SceneManager.LoadScene(GameManager.sceneName);
        }
        else
        {
            // 안내문구 팝업
            // alert.SetActive(true);
        }
    }

    /// <summary>
    /// <br>배너 클릭 시 이벤트 입니다.</br>
    /// </summary>
    public void MakerButton()
    {
        SceneManager.LoadScene("Maker");
    }
}