using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class map0_N00 : MonoBehaviour
{
    // 인스펙터에서 연결할 오브젝트 입니다.
    public Print print;

    // 침실 안내 메시지가 최초 1회만 출력되게 합니다.
    void Start()
    {
        if (GameManager.boolMap0_N00_Flag == true)
        {
            print.ObjectPrint("map0_N00_침실안내문");
            GameManager.boolMap0_N00_Flag = false;
        }
    }
}
