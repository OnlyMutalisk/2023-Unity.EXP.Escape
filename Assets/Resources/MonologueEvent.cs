using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonologueEvent : MonoBehaviour
{
    // 인스펙터에서 연결하며, 이벤트에서 사용할 오브젝트 입니다.
    public CutScene cutScene;
    public Monologue monologue;
    public Monologue dialogue;

    /// <summary>
    /// <br>여기에 이벤트 발생 시 작동할 코드를 입력합니다.</br>
    /// <br>각 케이스는 독백 텍스트의 index 입니다.</br>
    /// </summary>
    public void Event(string messageName)
    {
        switch (messageName)
        {
            case "로드뷰_잠김":
                switch (Monologue.monologueEventFlag)
                {
                    // 독백 & 대화 텍스트 [0] 일 때 발생할 이벤트
                    case 0:
                        cutScene.PopUpImage(1, 0);
                        break;

                    // 독백을 닫을 때 발생할 이벤트
                    case 1:
                        cutScene.PopDownImage(1, 0);
                        break;
                }
                break;

            case "map0_N08_침실문":
                switch (Monologue.monologueEventFlag)
                {
                    // 독백 & 대화 텍스트 [0] 일 때 발생할 이벤트
                    case 0:
                        cutScene.PopUpImage(0, 0);
                        break;

                    // 독백 & 대화 텍스트 [1] 일 때 발생할 이벤트
                    case 2:
                        cutScene.PopDownImage(0, 0);
                        SceneManager.LoadScene("map0_N07");
                        break;
                }
                break;

            case "map0_N04_침실창문":
                switch (Monologue.monologueEventFlag)
                {
                    // 독백 & 대화 텍스트 [1] 일 때 발생할 이벤트
                    case 1:
                        Room.SFX_재생("locked_door");
                        GameManager.boolMap0_N04_Flag = false;
                        break;

                    // 독백 & 대화 텍스트 [3] 일 때 발생할 이벤트
                    case 3:
                        SceneManager.LoadScene("map0_N03");
                        LockedRoadViews.lockedRoadViews.Add("map0_N03>>map0_N07");
                        GameManager.boolMap0_N03_Flag = true;
                        break;
                }
                break;

            case "map0_N05_세탁기":
                switch (Monologue.monologueEventFlag)
                {
                    // 독백 & 대화 텍스트 [1] 일 때 발생할 이벤트
                    case 1:
                        SceneManager.LoadScene("map0_C01");
                        break;
                }
                break;

            case "map0_C01_컷신3":
                switch (Monologue.monologueEventFlag)
                {
                    // 독백 & 대화 텍스트 [0] 일 때 발생할 이벤트
                    case 0:
                        cutScene.PopUpImage(0, 1f);
                        Room.SFX_재생("funeral_bell");
                        break;

                    // 독백 & 대화 텍스트 [1] 일 때 발생할 이벤트
                    case 1:
                        monologue.PrintMonologue("map0_C01_컷신4");
                        break;
                }
                break;

            case "map0_C01_컷신4":
                switch (Monologue.monologueEventFlag)
                {
                    // 독백 & 대화 텍스트 [4] 일 때 발생할 이벤트
                    case 4:
                        monologue.PrintMonologue("map0_C01_컷신5");
                        cutScene.PopUpImage(1, 1f);
                        Room.SFX_재생("mom_crying");
                        break;
                }
                break;

            case "map0_C01_컷신5":
                switch (Monologue.monologueEventFlag)
                {
                    // 독백 & 대화 텍스트 [1] 일 때 발생할 이벤트
                    case 1:
                        Monologue.monologueEventFlag = 0;
                        monologue.PrintMonologue("map0_C01_컷신6");
                        break;
                }
                break;

            case "map0_C01_컷신6":
                switch (Monologue.monologueEventFlag)
                {
                    // 독백 & 대화 텍스트 [1] 일 때 발생할 이벤트
                    case 1:
                        cutScene.PopUpImage(2, 1f);
                        break;

                    // 독백 & 대화 텍스트 [6] 일 때 발생할 이벤트
                    case 6:
                        Room.SFX_재생("confused");
                        break;

                    // 독백 & 대화 텍스트 [8] 일 때 발생할 이벤트
                    case 8:
                        cutScene.PopDownImage(0, 1f);
                        cutScene.PopDownImage(1, 1f);
                        cutScene.PopDownImage(2, 1f);
                        break;

                    // 독백 & 대화 텍스트 [9] 일 때 발생할 이벤트
                    case 9:
                        SceneManager.LoadScene("map0_C02");
                        break;
                }
                break;

            case "map0_C02_컷신3":
                switch (Monologue.monologueEventFlag)
                {
                    // 독백 & 대화 텍스트 [0] 일 때 발생할 이벤트
                    case 0:
                        cutScene.PopUpImage(0, 1f);
                        Room.SFX_재생("applaud");
                        break;

                    // 독백 & 대화 텍스트 [1] 일 때 발생할 이벤트
                    case 1:
                        monologue.PrintMonologue("map0_C02_컷신4");
                        break;
                }
                break;

            case "map0_C02_컷신4":
                switch (Monologue.monologueEventFlag)
                {
                    // 독백 & 대화 텍스트 [2] 일 때 발생할 이벤트
                    case 2:
                        cutScene.PopUpImage(1, 1f);
                        break;

                    // 독백 & 대화 텍스트 [3] 일 때 발생할 이벤트
                    case 3:
                        monologue.PrintMonologue("map0_C02_컷신5");
                        break;
                }
                break;

            case "map0_C02_컷신5":
                switch (Monologue.monologueEventFlag)
                {
                    // 독백 & 대화 텍스트 [0] 일 때 발생할 이벤트
                    case 0:
                        monologue.PrintMonologue("map0_C02_컷신6");
                        break;
                }
                break;

            case "map0_C02_컷신6":
                switch (Monologue.monologueEventFlag)
                {
                    // 독백 & 대화 텍스트 [1] 일 때 발생할 이벤트
                    case 1:
                        Room.SFX_재생("camera");
                        break;

                    // 독백 & 대화 텍스트 [2] 일 때 발생할 이벤트
                    case 2:
                        cutScene.PopUpImage(2, 1f);
                        break;

                    // 독백 & 대화 텍스트 [3] 일 때 발생할 이벤트
                    case 3:
                        monologue.PrintMonologue("map0_C02_컷신7");
                        break;
                }
                break;

            case "map0_C02_컷신7":
                switch (Monologue.monologueEventFlag)
                {
                    // 독백 & 대화 텍스트 [1] 일 때 발생할 이벤트
                    case 1:
                        cutScene.PopDownImage(0, 1f);
                        cutScene.PopDownImage(1, 1f);
                        cutScene.PopDownImage(2, 1f);
                        monologue.PrintMonologue("map0_C02_컷신8");
                        break;
                }
                break;

            case "map0_C02_컷신8":
                switch (Monologue.monologueEventFlag)
                {
                    // 독백 & 대화 텍스트 [0] 일 때 발생할 이벤트
                    case 0:
                        break;
                }
                break;

        }
    }
}