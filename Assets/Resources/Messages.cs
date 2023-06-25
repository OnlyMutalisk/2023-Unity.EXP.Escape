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

    // 각 씬 독백 메시지 덩어리 모음 입니다.
    public static LinkedList<string> Room = new LinkedList<string>();
    public static LinkedList<string> map0_독백 = new LinkedList<string>();
    public static LinkedList<string> map0_거실1 = new LinkedList<string>();
    public static LinkedList<string> map0_복도1 = new LinkedList<string>();

    static Messages()
    {
        // 오브젝트 "TESTOBJECT" 의 상호작용 대사 입니다.
        TESTOBJECT.title = "< ㅎㅇ >";
        TESTOBJECT.message = "dd";
        TESTOBJECT.time = 1;

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

        // 씬 "map0_거실0" 의 독백 대사 입니다.
        map0_거실1.AddLast("안녕하세요~");
        map0_거실1.AddLast("반갑습니다~");
        map0_거실1.AddLast("마지막 텍스트 입니다.");

        // 씬 "map0_복도1" 의 독백 대사 입니다.
        map0_복도1.AddLast("ㅇㅇ~");
        map0_복도1.AddLast("ㅋㅋ~");
        map0_복도1.AddLast("ㄷㄷ");
    }
}