using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadViewOnOff : MonoBehaviour
{
    public GameObject[] RoadView;

    /// <summary>
    /// <br>로드뷰의 On / Off 상태를 변환합니다.</br>
    /// </summary>
    public void RoadViewOnOffControl()
    {
        // 모든 로드뷰에 대하여,
        for (int i = 0; i < RoadView.Length; i++)
        {
            // 로드뷰가 켜져 있다면
            if (RoadView[i].active)
            {
                // 로드 뷰를 끕니다.
                RoadView[i].SetActive(false);
            }
            // 로드뷰가 꺼져 있다면
            else
            {
                // 로드뷰를 켭니다.
                RoadView[i].SetActive(true);
            }
        }
    }
}