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
        block.active = true;
        print.ObjectPrint("튜토리얼_타이머");
    }

    // 로드뷰 온, 오프 버튼 클릭 시 출력합니다.
    public void ClickRoadViewsOnOff()
    {
        block.active = true;
        print.ObjectPrint("튜토리얼_로드뷰");
    }

    // 아이템 온, 오프 버튼 클릭 시 출력합니다.
    public void ClickInventoryOnOff()
    {
        block.active = true;
        print.ObjectPrint("튜토리얼_인벤토리");
    }

    void Update()
    {
        if (!panel.gameObject.active)
        {
            StartCoroutine(disableBlock());
        }
    }

    public IEnumerator disableBlock()
    {
        yield return new WaitForSeconds(0.5f);

        block.active = false;
    }
}
