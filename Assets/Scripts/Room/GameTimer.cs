using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    #region 내부 구현

    public Text GameTimeText;
    public static bool IsPause;

    void Update()
    {
        if (!IsPause)
        {
            // 9999는 제한시간 없음을 나타내며, 타이머를 중지합니다.
            if ((int)GameManager.gameTime[GameManager.map] == 9999)
            {
                GameTimeText.text = "99 : 99";
                TimerOff();
                return;
            }

            // 타이머가 0에 도달하면 종료 이벤트를 발생시킵니다.
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
