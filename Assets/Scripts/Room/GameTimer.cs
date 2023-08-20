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

    // 타이머의 디폴트 상태 입니다.
    private void Awake()
    {
        GameTimeText.color = new Color(0.3568f, 0.3568f, 0.3568f, 1);
        GameTimeText.text = "00 : 00";
    }

    // 타이머를 갱신합니다.
    void Update()
    {
        if (!IsPause)
        {
            GameTimeText.color = new Color(1, 1, 1, 1);

            // 9999는 제한시간 없음을 나타내며, 타이머를 중지합니다.
            if ((int)GameManager.gameTime[GameManager.map] == 9999)
            {
                GameTimeText.text = "00 : 00";
                GameTimeText.color = new Color(0.3568f, 0.3568f, 0.3568f, 1);
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
        IsPause = true;
    }
}
