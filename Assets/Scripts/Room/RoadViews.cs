using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public partial class RoadViews : MonoBehaviour
{
    // 로드뷰가 잠겨있지 않다면 지정한 씬으로 이동합니다.
    public void Move(string nextSceneName)
    {
        string nowSceneName = SceneManager.GetActiveScene().name;
        string roadViewName = nowSceneName + ">>" + nextSceneName;
        bool isLock = false;

        // 현재 로드뷰가 잠긴 로드뷰인지 체크합니다.
        foreach (string lockedRoadView in GameManager.lockedRoadViews)
        {
            // 만약 잠긴 로드뷰라면 플래그를 true로 바꿉니다.
            if (roadViewName == lockedRoadView)
            {
                isLock = true;
                break;
            }
        }

        // 잠긴 로드뷰라면 이벤트 함수를 실행합니다.
        if (isLock == true)
        {
            LockedRoadView(roadViewName);
        }
        // 열린 로드뷰라면 지정한 씬으로 이동합니다.
        else
        {
            Room.SFX_재생("Move");
            SceneManager.LoadScene(nextSceneName);
            GameManager.sceneName = nextSceneName;
        }
    }
}
