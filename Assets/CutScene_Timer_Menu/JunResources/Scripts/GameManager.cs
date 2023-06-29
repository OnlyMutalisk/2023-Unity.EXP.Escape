using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region 타이머관련변수
    public static int round;
    public static bool IsPause;
    #endregion

    void Start()
    {
        round = 3;
    }

    void Update()
    {
        
    }

    //게임 종료 버튼
    public void GameExit()
    {
        Application.Quit();
    }
}
