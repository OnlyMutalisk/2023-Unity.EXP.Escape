using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // 씬의 시작 시 페이드 인 & 아웃 시간 입니다.
    public static float floatSceneFadeInOutTime = 1;
    public static float floatRoomNameFadeInOutTime = 2;

    // 현재 맵 번호를 나타냅니다.
    public static int map = 0;

    // 각 맵의 제한시간 입니다. 제한시간이 없다면 9999로 설정합니다.
    public static float[] gameTime = {9999, 9999, 1000, 1000};

    #region 세이브_데이터

    // 침실 안내 메시지가 최초 1회만 출력되게 하기 위한 플래그 입니다.
    public static bool boolMap0_N00_Flag = true;

    // 침실 창문 접근 메시지가 최초 1회만 출력되게 하기 위한 플래그 입니다.
    public static bool boolMap0_N04_Flag = true;

    // map0_N03 의 독백이 침실 창문 접근 후 1회만 출력되게 하기 위한 플래그 입니다.
    public static bool boolMap0_N03_Flag = false;

    #endregion
}
