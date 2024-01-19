using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Begin : MonoBehaviour
{
    public GameObject confirmation;
    public GameObject alert;
    public GameObject Cutscenes;

    #region 내부 구현

    // 컷신 재생이 게임 진행으로부터인지, 메인 화면을 통한 것인지 확인합니다.
    // true 라면 정상 게임 진행, false 라면 메인 화면을 통한 것 입니다.
    public static bool boolCheckCutscene = true;

    // 해상도 바깥 부분 빛번짐을 막기 위해, 로딩 화면을 0.5 초 동안 출력합니다.
    public void Start()
    {
        StartCoroutine(LoadingWait());
    }

    public IEnumerator LoadingWait()
    {
        yield return new WaitForSeconds(0.5f);

        try
        {
            GameObject.Find("Loading").SetActive(false);
        }
        catch (System.Exception)
        {
            // 단순히 아무 동작도 하지 않고 넘기기 위한 try catch 문 입니다.
        }

    }

    #endregion

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

    /// <summary>
    /// <br>컷신으로 넘어가기 위한 코드 입니다.</br>
    /// </summary>
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        boolCheckCutscene = false;
    }

    /// <summary>
    /// <br>컷신을 위한 BGM 입니다.</br>
    /// </summary>
    public void BGM(string BGM)
    {
        Room.BGM_재생(BGM);
    }
}