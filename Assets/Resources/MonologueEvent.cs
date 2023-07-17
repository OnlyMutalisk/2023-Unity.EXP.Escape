using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor.VersionControl;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonologueEvent : MonoBehaviour
{
    // 인스펙터에서 연결하며, 이벤트에서 사용할 컷신 관리 오브젝트 입니다.
    public CutScene cutScene;

    /// <summary>
    /// <br>여기에 이벤트 발생 시 작동할 코드를 입력합니다.</br>
    /// <br>각 케이스는 독백 텍스트의 index 입니다.</br>
    /// </summary>
    public void Event(string messageName)
    {
        switch (messageName)
        {
            // 로드뷰_잠김 메시지에서
            case "로드뷰_잠김":
                switch (Monologue.monologueEventFlag)
                {
                    // 독백 텍스트 [0] 일 때 발생할 이벤트
                    case 0:
                        cutScene.PopUpImage(1, 0);
                        break;

                    // 독백을 닫을 때 발생할 이벤트
                    case 1:
                        cutScene.PopDownImage(1, 0);
                        break;
                }
                break;


            // Room 메시지에서
            case "Room":
                switch (Monologue.monologueEventFlag)
                {
                    // 독백 텍스트 [0] 일 때 발생할 이벤트
                    case 0:
                        cutScene.FadeOutBackground();
                        cutScene.PopUpImage(1, 1);
                        break;

                    // 독백 텍스트 [1] 일 때 발생할 이벤트
                    case 1:
                        cutScene.PopUpImage(2, 1);
                        break;

                    // 독백 텍스트 [2] 일 때 발생할 이벤트
                    case 2:
                        cutScene.ShakeImage(1);
                        cutScene.PopUpImage(3, 1);
                        break;

                    // 독백 텍스트 [3] 일 때 발생할 이벤트
                    case 3:
                        cutScene.ShakeImage(2);
                        cutScene.PopDownImage(1, 1);
                        break;

                    // 독백 텍스트 [4] 일 때 발생할 이벤트
                    case 4:
                        cutScene.PopDownImage(2, 1);
                        break;

                    // 독백 텍스트 [5] 일 때 발생할 이벤트
                    case 5:
                        cutScene.FadeInBackground();
                        cutScene.PopDownImage(3, 1);
                        break;
                }
                break;

            // map0_거실1 메시지에서
            case "map0_거실1":
                switch (Monologue.monologueEventFlag)
                {
                    // 독백 텍스트 [0] 일 때 발생할 이벤트
                    case 0:
                        cutScene.FadeOutBackground();
                        cutScene.PopUpImage(1, 1);
                        break;

                    // 독백 텍스트 [1] 일 때 발생할 이벤트
                    case 1:
                        cutScene.PopUpImage(2, 1);
                        break;

                    // 독백 텍스트 [2] 일 때 발생할 이벤트
                    case 2:
                        cutScene.ShakeImage(1);
                        cutScene.PopUpImage(3, 1);
                        break;

                    // 독백 텍스트 [3] 일 때 발생할 이벤트
                    case 3:
                        cutScene.ShakeImage(2);
                        cutScene.PopDownImage(1, 1);
                        break;

                    // 독백 텍스트 [4] 일 때 발생할 이벤트
                    case 4:
                        cutScene.PopDownImage(2, 1);
                        break;

                    // 독백 텍스트 [5] 일 때 발생할 이벤트
                    case 5:
                        cutScene.FadeInBackground();
                        cutScene.PopDownImage(3, 1);
                        break;
                }
                break;
        }
    }
}