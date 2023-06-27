using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map0_튜토리얼 : MonoBehaviour
{
    // 인스펙터에서 연결할 오브젝트 입니다.
    public Print print;
    public GameObject panel;
    public GameObject block;

    // 튜토리얼 입장 시 메시지를 출력합니다.
    void Start()
    {
        print.ObjectPrint("튜토리얼");
    }

    // 타이머 클릭 시 출력합니다.
    public void ClickTimer()
    {
        print.ObjectPrint("튜토리얼_타이머");
    }

    // 로드뷰 온, 오프 버튼 클릭 시 출력합니다.
    public void ClickRoadViewsOnOff()
    {
        print.ObjectPrint("튜토리얼_로드뷰");
    }

    // 아이템 온, 오프 버튼 클릭 시 출력합니다.
    public void ClickInventoryOnOff()
    {
        print.ObjectPrint("튜토리얼_인벤토리");
    }

    void Update()
    {
        if (panel.gameObject.active)
        {
            block.active = true;
        }
        else
        {
            block.active = false;
        }
    }
}
