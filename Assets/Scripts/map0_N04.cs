using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map0_N04 : MonoBehaviour
{
    public GameObject 침실창문;

    // 이전에 이미 상호작용 한 적이 있다면, 침실 창문 상호작용을 비활성화 합니다.
    void Start()
    {
        if (GameManager.boolMap0_N04_Flag == false)
        {
            침실창문.SetActive(false);
        }
    }
}
