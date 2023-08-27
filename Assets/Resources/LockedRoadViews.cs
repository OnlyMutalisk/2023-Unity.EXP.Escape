using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedRoadViews : MonoBehaviour
{


    /// <summary>
    /// <br>잠긴 로드뷰를 초기 상태로 복귀시킵니다.</br>
    /// <br>Begin 씬에서, "처음부터" 버튼을 클릭 했을 때에만 작동합니다.</br>
    /// </summary>
    public void ResetLockedRoadViews()
    {
        GameManager.lockedRoadViews.Clear();
        GameManager.lockedRoadViews.AddRange(GameManager.lockedRoadViewsRESET);
    }

    // 잠글 로드뷰를 여기에 추가합니다.
    public void Start()
    {
        GameManager.lockedRoadViews.Add("map0_튜토리얼>>map0_거실1");

        #region 내부 구현

        // 리셋용 리스트에 저장합니다.
        GameManager.lockedRoadViewsRESET.Clear();
        GameManager.lockedRoadViewsRESET.AddRange(GameManager.lockedRoadViews);

        #endregion
    }


}
