using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class RoadViews : MonoBehaviour
{
    public CutScene cutScene;
    public Print print;
    public Monologue monologue;

    /// <summary>
    /// <br>잠긴 로드뷰에 접근했을 때의 이벤트 입니다.</br>
    /// <br>우선 Resources 폴더의 LockedRoadViews 스크립트에서 잠글 로드뷰를 리스트에 추가해야 합니다.</br>
    /// </summary>
    public void LockedRoadView(string roadViewName)
    {
        switch (roadViewName)
        {
            //case "map0_튜토리얼>>map0_거실1":
            //    print.ObjectPrint("TESTOBJECT");
            //    break;
            default:
                monologue.PrintMonologue("로드뷰_잠김");
                break;
        }
    }
}
