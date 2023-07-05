using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    #region 내부 구현

    public Text GameTimeText;
    public static int round = 3;
    public static bool IsPause;

    void Update()
    {
        if (round != 3 && round != 4)
        {
            GameTimeText.text = "99 : 99";
        }
        else if (!IsPause)
        {
            GameManager.gameTime[GameManager.map] -= Time.deltaTime;
            GameTimeText.text = (int)GameManager.gameTime[GameManager.map] / 60 + " : " + (int)GameManager.gameTime[GameManager.map] % 60;
            if ((int)GameManager.gameTime[GameManager.map] == 0)
            {
                TimerEnd();
            }
        }
    }

    #endregion

    // 타이머를 정지합니다.
    public static void TimerOff()
    {
        IsPause = true;
    }

    // 타이머를 재개합니다.
    public static void TimerOn()
    {
        IsPause = false;
    }

    // 타이머 시간 초과 시 동작할 스크립트 작성
    public void TimerEnd()
    {

    }
}
