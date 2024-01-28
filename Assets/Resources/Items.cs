using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

#region 내부 구현

public class Item
{
    // 아이템의 속성 입니다.
    public string name;
    public Sprite sprite;

    // 아이템 목록을 저장하는 정적 리스트 입니다.
    public static List<Item> items = new List<Item>();

    // 생성한 현재 아이템을 정적 아이템 목록에 추가합니다.
    public Item(string name)
    {
        // 생성과 동시에 아이템 목록에 추가합니다.
        Item.items.Add(this);
        this.name = name;
    }
}

#endregion

public class Items : MonoBehaviour
{
    // 이 곳에 아이템을 추가합니다.
    public static Dictionary<String, String> 설명 = new Dictionary<String, String>();
    public static Item 열쇠 = new Item("열쇠");
    public static Item 건전지 = new Item("건전지");
    public static Item 헤어핀 = new Item("헤어핀");
    public static Item 드릴 = new Item("드릴");
    public static Item 망치 = new Item("망치");

    // 이 곳에 아이템 설명을 추가합니다.
    public static void Add()
    {
        설명.Add("열쇠", "문을 여는 데 필요한 열쇠다.");
        설명.Add("건전지", "각종 전자제품에 사용되는 건전지다.");
        설명.Add("헤어핀", "흔한 헤어핀이지만, 다른 목적으로도 사용 가능 할 것 같다.\n\n # 10% 확률로 문을 딸 수 있습니다.");
        설명.Add("드릴", "나사를 조이고, 풀 수 있는 드라이버.\n\n # 30% 확률로 문고리를 해체할 수 있습니다.");
        설명.Add("망치", "심플한 디자인과 파괴적인 위력.\n\n # 100% 확률로 문을 부술 수 있습니다.");
    }

    #region 내부 구현

    public void Start()
    {
        // 아이템 이름에 해당하는 이미지를 탐색하여 적용합니다.
        foreach (var item in Item.items)
        {
            item.sprite = Resources.Load<Sprite>("Images/Items/" + item.name);
        }
    }

    #endregion
}

