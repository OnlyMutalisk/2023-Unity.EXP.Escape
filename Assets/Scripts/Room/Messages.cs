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
    public static LinkedList<string> map0_독백 = new LinkedList<string>();

    static Messages()
    {
        // 오브젝트 "TESTOBJECT" 의 상호작용 대사 입니다.
        TESTOBJECT.title = "< ㅎㅇ >";
        TESTOBJECT.message = "dd";
        TESTOBJECT.time = 1;

        // 씬 "map0_독백" 의 독백 대사 입니다.
        map0_독백.AddLast("안녕하세요~");
        map0_독백.AddLast("반갑습니다~");
        map0_독백.AddLast("마지막 텍스트 입니다.");
    }
}