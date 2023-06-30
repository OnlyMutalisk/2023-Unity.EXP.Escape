using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // 현재 맵 번호를 나타냅니다.
    public static int map = 0;

    // 각 맵의 제한시간 입니다.
    public static float[] gameTime = {1000, 0, 1000, 1000};

}
