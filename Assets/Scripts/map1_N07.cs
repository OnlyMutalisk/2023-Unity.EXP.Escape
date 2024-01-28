using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 건전지를 획득한 적이 있다면 해당 오브젝트를 비활성화합니다.
public class map1_N07 : MonoBehaviour
{
    public static bool isGetBattery리모콘 = false;
    public static bool isGetBattery에어컨 = false;

    public GameObject battery리모콘;
    public GameObject battery에어컨;

    public void Awake()
    {
        if (isGetBattery리모콘 == true)
        {
            battery리모콘.SetActive(false);
        }

        if (isGetBattery에어컨 == true)
        {
            battery에어컨.SetActive(false);
        }
    }

    public void 리모콘_배터리_획득()
    {
        isGetBattery리모콘 = true;
    }

    public void 에어컨_배터리_획득()
    {
        isGetBattery에어컨 = true;
    }
}
