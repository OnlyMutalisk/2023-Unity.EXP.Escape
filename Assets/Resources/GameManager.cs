using System.Collections;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // 남은 시간이 A초 보다 작다면, 다음에 불러오기 할 때 B초로 시작합니다.
    public static float thresholdTime = 10;
    public static float finalTime = 10;

    // 씬의 시작 시 페이드 인 & 아웃 시간 입니다.
    public static float floatSceneFadeInOutTime = 1;
    public static float floatRoomNameFadeInOutTime = 2;

    // 스크립트 출력 속도를 설정 합니다.
    public static float floatTypingSpeed = 0.05f;

    // 데이터 저장 경로 입니다.
    public static string path = Path.Combine(Application.persistentDataPath, "data.json");

    #region 세이브_데이터

    public static void SAVE()
    {
        // 데이터 틀을 만듭니다.
        Data data = new Data
        {
            // 데이터 틀에 현재 데이터들을 담습니다.
            gameTime = GameManager.gameTime,
            map = GameManager.map,
            inventory = GameManager.inventory,
            sceneName = GameManager.sceneName,
            lockedRoadViewsRESET = GameManager.lockedRoadViewsRESET,
            lockedRoadViews = GameManager.lockedRoadViews,
            boolMap0_N00_Flag = GameManager.boolMap0_N00_Flag,
            boolMap1_N09_Flag = GameManager.boolMap1_N09_Flag,
            intMap1_N09_Doorlock = GameManager.intMap1_N09_Doorlock,
            boolMap2_N12_Flag = GameManager.boolMap2_N12_Flag,
        };

        // 데이터를 JSON 으로 직렬화합니다.
        string jsonData = JsonConvert.SerializeObject(data);

        // 직렬화한 데이터를 파일로 저장합니다.
        File.WriteAllText(path, jsonData);
    }

    public static void LOAD()
    {
        // 파일로 저장한 데이터를 직렬화 된 상태로 가져옵니다.
        string jsonData = File.ReadAllText(path);

        // 직렬화를 풀어 데이터 틀에 담습니다.
        Data data = JsonConvert.DeserializeObject<Data>(jsonData);

        // 현재 데이터로 덮어씁니다.
        GameManager.gameTime = data.gameTime;
        GameManager.map = data.map;
        GameManager.sceneName = data.sceneName;
        GameManager.inventory = data.inventory;
        GameManager.lockedRoadViewsRESET = data.lockedRoadViewsRESET;
        GameManager.lockedRoadViews = data.lockedRoadViews;
        GameManager.boolMap0_N00_Flag = data.boolMap0_N00_Flag;
        GameManager.boolMap1_N09_Flag = data.boolMap1_N09_Flag;
        GameManager.intMap1_N09_Doorlock = data.intMap1_N09_Doorlock;
        GameManager.boolMap2_N12_Flag = data.boolMap2_N12_Flag;
    }

    public static void RESET()
    {
        gameTime = new float[] { 30, 9999, 1000, 1000 };
        map = 0;
        sceneName = null;
        inventory = new List<Item>();
        lockedRoadViewsRESET = new List<string>();
        lockedRoadViews = new List<string>();
        boolMap0_N00_Flag = true;
        boolMap1_N09_Flag = false;
        intMap1_N09_Doorlock = 0;
        boolMap2_N12_Flag = false;
    }

    // 각 맵의 제한시간 입니다. 제한시간이 없다면 9999로 설정합니다.
    public static float[] gameTime = { 30, 9999, 1000, 1000 };

    // 현재 맵 번호를 나타냅니다.
    public static int map = 0;

    // 현재 씬 정보를 나타냅니다.
    public static string sceneName = null;

    // 인벤토리에 저장되어있는 아이템 리스트 입니다.
    public static List<Item> inventory = new List<Item>();

    // 초기 잠금 설정 된 도로뷰 입니다.
    public static List<string> lockedRoadViewsRESET = new List<string>();

    // 현재 잠긴 상태의 도로뷰 입니다.
    public static List<string> lockedRoadViews = new List<string>();

    // 침실 안내 메시지가 최초 1회만 출력되게 하기 위한 플래그 입니다.
    public static bool boolMap0_N00_Flag = true;

    // map1_N09 의 현관문 최초 접근 스크립트를 출력하기 위한 플래그 입니다.
    public static bool boolMap1_N09_Flag = false;

    // map2_N12 의 화장실 최초 접근 스크립트를 출력하기 위한 플래그 입니다.
    public static bool boolMap2_N12_Flag = false;

    // 도어락에 장착된 건전지 수 입니다.
    public static int intMap1_N09_Doorlock = 0;

    #endregion
}

// 데이터 틀 입니다.
public class Data
{
    public float[] gameTime;
    public int map;
    public string sceneName;
    public List<Item> inventory;
    public List<string> lockedRoadViewsRESET;
    public List<string> lockedRoadViews;
    public bool boolMap0_N00_Flag;
    public bool boolMap1_N09_Flag;
    public int intMap1_N09_Doorlock;
    public bool boolMap2_N12_Flag;
}