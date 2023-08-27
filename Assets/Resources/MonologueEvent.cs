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
            // case N:번째 독백 & 대화 텍스트 일 때 발생할 이벤트

            case "로드뷰_잠김":
                switch (Monologue.monologueEventFlag)
                {
                    case 0:
                        cutScene.PopUpImage(1, 0);
                        break;

                    case 1:
                        cutScene.PopDownImage(1, 0);
                        break;
                }
                break;

            case "map0_N08_침실문":
                switch (Monologue.monologueEventFlag)
                {
                    case 0:
                        Room.SFX_재생("locked_door");
                        break;

                    case 2:
                        SceneManager.LoadScene("map0_N07");
                        GameManager.sceneName = "map0_N07";
                        break;
                }
                break;

            case "map0_N04_침실창문":
                switch (Monologue.monologueEventFlag)
                {
                    case 1:
                        Room.SFX_재생("locked_door");
                        GameManager.boolMap0_N04_Flag = false;
                        break;

                    case 3:
                        SceneManager.LoadScene("map0_N03");
                        GameManager.sceneName = "map0_N03";
                        GameManager.lockedRoadViews.Add("map0_N03>>map0_N07");
                        GameManager.boolMap0_N03_Flag = true;
                        break;
                }
                break;

            case "map0_N05_세탁기":
                switch (Monologue.monologueEventFlag)
                {
                    case 1:
                        SceneManager.LoadScene("map0_C01");
                        GameManager.sceneName = "map0_C01";
                        break;
                }
                break;

            case "map0_C01_컷신3":
                switch (Monologue.monologueEventFlag)
                {
                    case 0:
                        cutScene.PopUpImage(0, 1f);
                        Room.SFX_재생("funeral_bell");
                        break;

                    case 6:
                        cutScene.PopUpImage(1, 1f);
                        Room.SFX_재생("mom_crying");
                        break;

                    case 10:
                        cutScene.PopUpImage(2, 1f);
                        break;

                    case 15:
                        Room.SFX_재생("confused");
                        break;

                    case 17:
                        cutScene.PopDownImage(0, 1f);
                        cutScene.PopDownImage(1, 1f);
                        cutScene.PopDownImage(2, 1f);
                        break;

                    case 18:
                        SceneManager.LoadScene("map0_C02");
                        GameManager.sceneName = "map0_C02";
                        break;
                }
                break;

            case "map0_C02_컷신3":
                switch (Monologue.monologueEventFlag)
                {
                    case 0:
                        cutScene.PopUpImage(0, 1f);
                        Room.SFX_재생("applaud");
                        break;

                    case 4:
                        cutScene.PopUpImage(1, 1f);
                        break;

                    case 8:
                        Room.SFX_재생("camera");
                        break;

                    case 9:
                        cutScene.PopUpImage(2, 1f);
                        break;

                    case 12:
                        cutScene.PopDownImage(0, 1f);
                        cutScene.PopDownImage(1, 1f);
                        cutScene.PopDownImage(2, 1f);
                        break;
                }
                break;
        }
    }
}