using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class RoadViews : MonoBehaviour
{
    public CutScene CutScene;
    public Print Print;
    public Monologue Monologue_or_Dialogue;

    /// <summary>
    /// <br>잠긴 로드뷰에 접근했을 때의 이벤트 입니다.</br>
    /// <br>우선 Resources 폴더의 LockedRoadViews 스크립트에서 잠글 로드뷰를 리스트에 추가해야 합니다.</br>
    /// </summary>
    public void LockedRoadView(string roadViewName)
    {
        switch (roadViewName)
        {
            case "map0_N03>>map0_N07":
                Monologue_or_Dialogue.PrintMonologue("map0_N03_N07_잠김");
                break;
            default:
                Monologue_or_Dialogue.PrintMonologue("로드뷰_잠김");
                break;
        }
    }
}
