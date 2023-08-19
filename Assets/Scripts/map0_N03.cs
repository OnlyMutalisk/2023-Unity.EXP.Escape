using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map0_N03 : MonoBehaviour
{
    // 인스펙터에서 연결할 오브젝트 입니다.
    public Monologue Dialogue;

    void Start()
    {
        if (GameManager.boolMap0_N03_Flag == true)
        {
            Dialogue.PrintMonologue("map0_N03_독백");
            GameManager.boolMap0_N03_Flag = false;
        }
    }
}
