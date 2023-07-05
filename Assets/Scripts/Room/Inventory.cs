using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    #region 내부 구현

    public static List<Item> inventory = new List<Item>();
    [SerializeField] private Transform slotParent;
    private Slot[] slots;

    private void OnValidate()
    {
        slots = slotParent.GetComponentsInChildren<Slot>();
    }

    private void Awake()
    {
        FreshSlot();
    }

    #endregion

    // 슬롯을 새로고침 합니다.
    public void FreshSlot()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < inventory.Count)
                slots[i].UpdateSlot(inventory[i]);
            else
                slots[i].UpdateSlot(null);
        }
    }

    // 인벤토리에 아이템을 추가합니다.
    public void AddItem(string itemName)
    {
        if (inventory.Count < slots.Length)
        {
            // 정적 아이템 목록 Items 에서 name 속성이 매개변수와 동일한 아이템 객체 찾기
            Item item = Item.items.FirstOrDefault(item => item.name == itemName);

            inventory.Add(item);
            FreshSlot();
        }
    }

    // 인벤토리에서 아이템을 제거합니다.
    public void RemoveItem(string itemName)
    {
        // 정적 아이템 목록 Items 에서 name 속성이 매개변수와 동일한 아이템 객체 찾기
        Item item = Item.items.FirstOrDefault(item => item.name == itemName);

        inventory.Remove(item);
        FreshSlot();
    }
}
