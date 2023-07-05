using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueBtn : MonoBehaviour
{
    public GameObject menu;

    // 계속하기 버튼 클릭 시 동작할 스크립트 입니다.
    public void ClickContinueButton()
    {
        GameTimer.TimerOn();
        menu.SetActive(false);
    }
}
