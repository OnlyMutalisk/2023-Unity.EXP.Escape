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
    public static ObjectMessage 튜토리얼 = new ObjectMessage();
    public static ObjectMessage 튜토리얼_타이머 = new ObjectMessage();
    public static ObjectMessage 튜토리얼_로드뷰 = new ObjectMessage();
    public static ObjectMessage 튜토리얼_인벤토리 = new ObjectMessage();
    public static ObjectMessage map0_N00_침실안내문 = new ObjectMessage();
    public static ObjectMessage map0_C01_컷신1 = new ObjectMessage();
    public static ObjectMessage map0_C01_컷신2 = new ObjectMessage();

    // 각 독백 & 대화 메시지 덩어리 모음 입니다.
    public static LinkedList<string> 로드뷰_잠김 = new LinkedList<string>();
    public static LinkedList<string> map0_독백 = new LinkedList<string>();
    public static LinkedList<string> map0_N07_TV = new LinkedList<string>();
    public static LinkedList<string> map0_N07_소파 = new LinkedList<string>();
    public static LinkedList<string> map0_N08_침실문 = new LinkedList<string>();
    public static LinkedList<string> map0_N08_작은액자 = new LinkedList<string>();
    public static LinkedList<string> map0_N08_큰액자 = new LinkedList<string>();
    public static LinkedList<string> map0_N04_침실창문 = new LinkedList<string>();
    public static LinkedList<string> map0_N03_독백 = new LinkedList<string>();
    public static LinkedList<string> map0_N03_N07_잠김 = new LinkedList<string>();
    public static LinkedList<string> map0_N02_화분들 = new LinkedList<string>();
    public static LinkedList<string> map0_N05_세탁기 = new LinkedList<string>();
    public static LinkedList<string> map0_C01 = new LinkedList<string>();
    public static LinkedList<string> map0_C01_컷신3 = new LinkedList<string>();
    public static LinkedList<string> map0_C01_컷신4 = new LinkedList<string>();

    static Messages()
    {
        #region 오브젝트 메시지

        // 오브젝트 "TESTOBJECT" 의 상호작용 대사 입니다.
        map0_N00_침실안내문.message = "일단 핸드폰부터 찾게 침실로 가자";
        map0_N00_침실안내문.time = 2;

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

        // 컷신 테스트
        map0_C01_컷신1.message = "잊고 싶어도 잊혀지지 않는 그런 순간이 있는가?";
        map0_C01_컷신1.time = 2;
        map0_C01_컷신2.message = "슬프게도 나는 아버지의 장례식이 그러했었다.";
        map0_C01_컷신2.time = 2;


        #endregion

        #region 독백 & 대화 메시지

        // "로드뷰_잠김" 의 대사 입니다.
        로드뷰_잠김.AddLast("아무래도 문이 잠긴 것 같다.");

        // "map0_독백" 의 대사 입니다.
        map0_독백.AddLast("으으윽... 머리야 내가 지금 어디에 있는 거지?");
        map0_독백.AddLast("분명 어제 침대에서 잠든 것 같은데 왜 내가 여기 있지?");
        map0_독백.AddLast("어제 도대체 뭔 일이 있었던 거야.");
        map0_독백.AddLast("뭐지 당최 기억이 없는데...");
        map0_독백.AddLast("핸드폰을 보면 좀 기억이 나려나?");
        map0_독백.AddLast("어… 그러고보니 핸드폰은 또 어디간거야?");
        map0_독백.AddLast("여기 없으면 침실에서 충전 중이려나….");
        map0_독백.AddLast("일단 핸드폰부터 찾고 정신 차려야겠어…....");

        // "map0_N07_TV" 의 대사 입니다.
        map0_N07_TV.AddLast("TV다. 지금은 별로 보고 싶지 않다.");

        // "map0_N07_소파" 의 대사 입니다.
        map0_N07_소파.AddLast("내가 종종 침대로 쓰고 있는 소파다.");

        // "map0_N08_침실문" 의 대사 입니다.
        map0_N08_침실문.AddLast("어? 잠겼다고? 그럴 리가 없는데?");
        map0_N08_침실문.AddLast("베란다 창문 쪽으로 들어가야 하나?");

        // "map0_N08_작은액자" 의 대사 입니다.
        map0_N08_작은액자.AddLast("대상 받았을 때 엄마랑 찍은 사진이다.");

        // "map0_N08_큰액자" 의 대사 입니다.
        map0_N08_큰액자.AddLast("이유는 모르겠지만 나름 좋아하는 그림이다.");

        // "map0_N04_침실창문" 의 대사 입니다.
        map0_N04_침실창문.AddLast("창문까지 잠겨있다고? 아니야 절대 그럴 리 없는데");
        map0_N04_침실창문.AddLast("...!");
        map0_N04_침실창문.AddLast("뭐야 갑자기 베란다 창문이 잠긴다고?");

        // "map0_N03_독백" 의 대사 입니다.
        map0_N03_독백.AddLast("진짜 누가 집 안에 있어? 장난치지 말고 빨리 나와?");
        map0_N03_독백.AddLast("세탁실에 예비 열쇠가 있으니 그것부터 찾자!");

        // "map0_N03_N07_잠김" 의 대사 입니다.
        map0_N03_N07_잠김.AddLast("베란다 창문이 잠겨버렸다.");

        // "map0_N02_화분들" 의 대사 입니다.
        map0_N02_화분들.AddLast("엄마가 기르는 풀때기다");

        // "map0_N05_세탁기" 의 대사 입니다.
        map0_N05_세탁기.AddLast("아 그러고 보니 이게 여기 있었네...");

        // "map0_C01" 의 대사 입니다.
        map0_C01.AddLast("잊고 싶어도 잊혀지지 않는 그런 순간이 있는가?");

        // "map0_C01_컷신3" 의 대사 입니다.
        map0_C01_컷신3.AddLast("고인을 위해 기도하는 시간을 갖겠습니다. 성부와 성자와 성령의 이름으로...");

        // "map0_C01_컷신4" 의 대사 입니다.
        map0_C01_컷신4.AddLast("이렇게 갑작스럽게 아버지가 돌아가실 줄은 몰랐다.");
        map0_C01_컷신4.AddLast("늘 일 때문에 바빠 함께하는 시간은 적었지만 아버지는 좋은 사람이었다.");
        map0_C01_컷신4.AddLast("슬픔 공허함? 아니 그냥 아무것도 느껴지지가 않는다.");
        map0_C01_컷신4.AddLast("이 모든 상황이 낯설고 어색하기만하다.");
        map0_C01_컷신4.AddLast("내일이면 아무 일 없다는 듯 집에 오실 것만 같았다.");
        

        #endregion
    }
}