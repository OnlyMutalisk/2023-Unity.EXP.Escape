using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEditor.VersionControl;
using UnityEditorInternal;
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
                break;

            case "map0_N04_침실창문":
                switch (Monologue.monologueEventFlag)
                {
                    // 독백 & 대화 텍스트 [1] 일 때 발생할 이벤트
                    case 1:
                        AudioSource audioSource = GetComponent<AudioSource>();
                        audioSource.clip = Resources.Load<AudioClip>("Sounds/Object/" + "locked_door");
                        GameManager.boolMap0_N04_Flag = false;
                        audioSource.Play();
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
                    // 독백 & 대화 텍스트 [1] 일 때 발생할 이벤트
                    case 1:
                        monologue.PrintMonologue("map0_C01_컷신4");
                        break;
                }
                break;

        }
    }
}