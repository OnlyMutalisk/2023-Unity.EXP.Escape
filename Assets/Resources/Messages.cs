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

public class Messages
{
    // 각 오브젝트 상호작용 메시지 모음 입니다.
    public static ObjectMessage TESTOBJECT = new ObjectMessage();
    public static ObjectMessage 튜토리얼 = new ObjectMessage();
    public static ObjectMessage 튜토리얼_타이머 = new ObjectMessage();
    public static ObjectMessage 튜토리얼_로드뷰 = new ObjectMessage();
    public static ObjectMessage 튜토리얼_인벤토리 = new ObjectMessage();

    // 각 독백 메시지 덩어리 모음 입니다.
    public static LinkedList<string> 로드뷰_잠김 = new LinkedList<string>();
    public static LinkedList<string> 독백_테스트 = new LinkedList<string>();
    public static LinkedList<string> map0_독백 = new LinkedList<string>();
    public static LinkedList<string> map0_거실1 = new LinkedList<string>();
    public static LinkedList<string> map0_복도1 = new LinkedList<string>();

    // 각 대화 메시지 덩어리 모음 입니다.
    public static LinkedList<string> 대화_테스트 = new LinkedList<string>();

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

        // "로드뷰_잠김" 의 독백 대사 입니다.
        로드뷰_잠김.AddLast("아무래도 문이 잠긴 것 같다.");

        // "독백_테스트" 의 독백 대사 입니다.
        독백_테스트.AddLast("독백 테스트 대사 1");
        독백_테스트.AddLast("독백 테스트 대사 2");
        독백_테스트.AddLast("독백 테스트 대사 3");
        독백_테스트.AddLast("독백 테스트 대사 4");
        독백_테스트.AddLast("독백 테스트 대사 5");
        독백_테스트.AddLast("독백 테스트 대사 6");
        독백_테스트.AddLast("독백 테스트 대사 마지막");

        // "map0_독백" 의 독백 대사 입니다.
        map0_독백.AddLast("주인공 독백 1");
        map0_독백.AddLast("주인공 독백 2");
        map0_독백.AddLast("주인공 독백 3");

        // "map0_거실1" 의 독백 대사 입니다.
        map0_거실1.AddLast("1~");
        map0_거실1.AddLast("2~");
        map0_거실1.AddLast("3~");
        map0_거실1.AddLast("4~");
        map0_거실1.AddLast("5~");
        map0_거실1.AddLast("6~");
        map0_거실1.AddLast("마지막");

        // "map0_복도1" 의 독백 대사 입니다.
        map0_복도1.AddLast("ㅇㅇ~");
        map0_복도1.AddLast("ㅋㅋ~");
        map0_복도1.AddLast("ㄷㄷ");

        #endregion

        #region 대화 메시지

        // "대화_테스트" 의 대화 대사 입니다.
        대화_테스트.AddLast("대화 테스트 대사 1");
        대화_테스트.AddLast("대화 테스트 대사 2");
        대화_테스트.AddLast("대화 테스트 대사 3");

        #endregion
    }
}