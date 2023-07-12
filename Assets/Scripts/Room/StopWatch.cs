using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopWatch : MonoBehaviour
{
    // 인스펙터에서 초침을 연결합니다.
    public RectTransform stick;

    // 처음에 주어진 시간을 저장합니다.
    public static float[] gameTime = new float[GameManager.gameTime.Length];

    private void Start()
    {
        if (gameTime[0] == 0)
        {
            Array.Copy(GameManager.gameTime, gameTime, GameManager.gameTime.Length);
        }
    }

    void Update()
    {
        // 초침의 회전값(z)을 -360 * (1 - (남은시간 / 원래시간)) 으로 변경합니다.
        stick.rotation = Quaternion.Euler(stick.rotation.x, stick.rotation.y, -360 * (1 - (GameManager.gameTime[GameManager.map] / gameTime[GameManager.map])));
    }
}
