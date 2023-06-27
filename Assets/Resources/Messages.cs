using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System;
using UnityEngine;

#region 내부 구현

public class ObjectMessage
{
    public string title;
    public string message;
    public float time;
}

#endregion

public class Messages : MonoBehaviour
{
    // 각 오브젝트 상호작용 메시지 모음 입니다.
    public static ObjectMessage TESTOBJECT = new ObjectMessage();
    public static ObjectMessage 튜토리얼 = new ObjectMessage();
    public static ObjectMessage 튜토리얼_타이머 = new ObjectMessage();
    public static ObjectMessage 튜토리얼_로드뷰 = new ObjectMessage();
    public static ObjectMessage 튜토리얼_인벤토리 = new ObjectMessage();

    // 각 씬 독백 메시지 덩어리 모음 입니다.
    public static LinkedList<string> Room = new LinkedList<string>();
    public static LinkedList<string> map0_독백 = new LinkedList<string>();
    public static LinkedList<string> map0_거실1 = new LinkedList<string>();
    public static LinkedList<string> map0_복도1 = new LinkedList<string>();

    static Messages()
    {
        #region 오브젝트 메시지

        // 오브젝트 "TESTOBJECT" 의 상호작용 대사 입니다.
        TESTOBJECT.title = "< ㅎㅇ >";
        TESTOBJECT.message = "dd";
        TESTOBJECT.time = 1;

        // 오브젝트 "튜토리얼" 의 상호작용 대사 입니다.
        튜토리얼.title = "< 튜토리얼 >";
        튜토리얼.message = "우측 상단 4개의 버튼을 각각 한 번씩 눌러보세요.\n익숙해졌다면, 다음 방으로 이동하세요.";
        튜토리얼.time = 3;

        // 오브젝트 "튜토리얼_타이머" 의 상호작용 대사 입니다.
        튜토리얼_타이머.title = "< 타이머 >";
        튜토리얼_타이머.message = "맵 클리어 까지 남은 시간 입니다.\n후반부 맵에서만 작동하며, 초반에는 제한시간이 없습니다.";
        튜토리얼_타이머.time = 2;

        // 오브젝트 "튜토리얼_로드뷰" 의 상호작용 대사 입니다.
        튜토리얼_로드뷰.title = "< 이동 >";
        튜토리얼_로드뷰.message = "화살표 버튼을 눌러 다른 방으로 이동할 수 있습니다.\n일부 방은 입장 조건이 있을 수 있습니다.";
        튜토리얼_로드뷰.time = 2;

        // 오브젝트 "튜토리얼_인벤토리" 의 상호작용 대사 입니다.
        튜토리얼_인벤토리.title = "< 아이템 확인 >";
        튜토리얼_인벤토리.message = "아이템 버튼을 누르면 다음과 같이 인벤토리 창이 나타납니다.\n인벤토리에서 아이템을 확인 or 사용할 수 있습니다.";
        튜토리얼_인벤토리.time = 2;

        #endregion

        #region 독백 메시지

        // 씬 "Room" 의 독백 대사 입니다.
        Room.AddLast("1~");
        Room.AddLast("2~");
        Room.AddLast("3~");
        Room.AddLast("4~");
        Room.AddLast("5~");
        Room.AddLast("6~");
        Room.AddLast("마지막");

        // 씬 "map0_독백" 의 독백 대사 입니다.
        map0_독백.AddLast("주인공 독백 1");
        map0_독백.AddLast("주인공 독백 2");
        map0_독백.AddLast("주인공 독백 3");

        // 씬 "map0_거실1" 의 독백 대사 입니다.
        map0_거실1.AddLast("1~");
        map0_거실1.AddLast("2~");
        map0_거실1.AddLast("3~");
        map0_거실1.AddLast("4~");
        map0_거실1.AddLast("5~");
        map0_거실1.AddLast("6~");
        map0_거실1.AddLast("마지막");

        // 씬 "map0_복도1" 의 독백 대사 입니다.
        map0_복도1.AddLast("ㅇㅇ~");
        map0_복도1.AddLast("ㅋㅋ~");
        map0_복도1.AddLast("ㄷㄷ");

        #endregion
    }
}