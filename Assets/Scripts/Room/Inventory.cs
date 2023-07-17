using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    // 인벤토리에 저장되어있는 아이템 리스트 입니다.
    public static List<Item> inventory = new List<Item>();

    // 현재 선택된 아이템 입니다.
    public string currentSlotItemName;

    #region 내부 구현

    [SerializeField] private Transform slotParent;
    private Slot[] slots;

    // 슬롯 클릭 이벤트를 위한 객체 입니다.
    public Image[] imageSlots;
    public Image[] imageSlotsItems;

    // 슬롯 클릭시 이벤트 입니다. 매개변수는 index번째 슬롯을 클릭했음을 의미합니다.
    public void ClickSlot(int index)
    {
        // 모든 슬롯을 초기 상태 컬러로 설정합니다.
        foreach (var imageSlot in imageSlots)
        {
            imageSlot.color = new Color(255, 255, 255, 0.560784f);
        }

        // 현재 슬롯에 아이템이 존재한다면,
        if(imageSlotsItems[index].sprite != null)
        {
            // 현재 슬롯의 아이템을 기록합니다.
            currentSlotItemName = imageSlotsItems[index].sprite.name;

            // 현재 슬롯의 컬러만 빨갛게 칠합니다.
            imageSlots[index].color = new Color(255, 0, 0, 0.560784f);
        }
        // 현재 슬롯에 아이템이 존재하지 않는다면,
        else
        {
            // 현재 선택된 아이템을 "" 로 리셋
            currentSlotItemName = "";
        }
    }

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
