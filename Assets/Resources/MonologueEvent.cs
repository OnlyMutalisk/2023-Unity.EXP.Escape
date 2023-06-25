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
    public void Event()
    {
        switch (SceneManager.GetActiveScene().name)
        {
            // Room 씬에서
            case "Room":
                switch (Monologue.monologueEventFlag)
                {
                    // 독백 텍스트 [0] 일 때 발생할 이벤트
                    case 0:
                        cutScene.FadeOutBackground();
                        cutScene.PopUpImage(0);
                        break;

                    // 독백 텍스트 [1] 일 때 발생할 이벤트
                    case 1:
                        cutScene.PopUpImage(1);
                        break;

                    // 독백 텍스트 [2] 일 때 발생할 이벤트
                    case 2:
                        cutScene.ShakeImage(0);
                        cutScene.PopUpImage(2);
                        break;

                    // 독백 텍스트 [3] 일 때 발생할 이벤트
                    case 3:
                        cutScene.ShakeImage(1);
                        cutScene.PopDownImage(0);
                        break;

                    // 독백 텍스트 [4] 일 때 발생할 이벤트
                    case 4:
                        cutScene.PopDownImage(1);
                        break;

                    // 독백 텍스트 [5] 일 때 발생할 이벤트
                    case 5:
                        cutScene.FadeInBackground();
                        cutScene.PopDownImage(2);
                        break;
                }
                break;

            // "test" 씬에서
            case "test":
                switch (Monologue.monologueEventFlag)
                {
                    // 독백 텍스트 [0] 일 때 발생할 이벤트
                    case 0:
                        break;

                    case 1:
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        break;

                    case 6:
                        break;
                }
                break;
        }
    }
}