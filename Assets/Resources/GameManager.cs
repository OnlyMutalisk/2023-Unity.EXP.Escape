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
    public static float[] gameTime = {9999, 0, 1000, 1000};

}
