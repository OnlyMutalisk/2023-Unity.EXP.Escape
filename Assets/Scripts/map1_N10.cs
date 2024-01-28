using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map1_N10 : MonoBehaviour
{
    public static bool isGetBattery주전자 = false;

    public GameObject battery주전자;

    public void Awake()
    {
        if (isGetBattery주전자 == true)
        {
            battery주전자.SetActive(false);
        }
    }

    public void 주전자_배터리_획득()
    {
        isGetBattery주전자 = true;
    }
}
