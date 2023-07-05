using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

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
    // 이 곳에 아이템을 추가 합니다.
    public static Item 열쇠 = new Item("열쇠");

    #region 내부 구현

    // 아이템 이름에 해당하는 이미지를 탐색하여 적용합니다.
    private void Start()
    {
        foreach (var item in Item.items)
        {
            item.sprite = Resources.Load<Sprite>("Items/" + item.name);
        }
    }

    #endregion
}

