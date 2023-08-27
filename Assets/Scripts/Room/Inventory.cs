using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    // 현재 선택된 아이템 입니다.
    public string currentSlotItemName;

    #region 내부 구현

    [SerializeField] private Transform slotParent;
    private Slot[] slots;

    // 슬롯 클릭 이벤트를 위한 객체 입니다.
    public GameObject[] imageSlots;
    public Image[] imageSlotsItems;

    // 슬롯 클릭시 이벤트 입니다. 매개변수는 index번째 슬롯을 클릭했음을 의미합니다.
    public void ClickSlot(int index)
    {
        // 모든 슬롯 선택 오브젝트를 비활성화 한 후, 현재 슬롯 선택 오브젝트만 활성화 합니다.
        foreach (var imageSlot in imageSlots)
        {
            imageSlot.SetActive(false);
        }

        imageSlots[index].SetActive(true);

        // 현재 슬롯에 아이템이 존재한다면,
        if (imageSlotsItems[index].sprite.name != "장비창_0")
        {
            // 현재 슬롯의 아이템을 기록합니다.
            currentSlotItemName = imageSlotsItems[index].sprite.name;
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
            if (i < GameManager.inventory.Count)
                slots[i].UpdateSlot(GameManager.inventory[i]);
            else
                slots[i].UpdateSlot(null);
        }
    }

    // 인벤토리에 아이템을 추가합니다.
    public void AddItem(string itemName)
    {
        if (GameManager.inventory.Count < slots.Length)
        {
            // 정적 아이템 목록 Items 에서 name 속성이 매개변수와 동일한 아이템 객체 찾기
            Item item = Item.items.FirstOrDefault(item => item.name == itemName);

            GameManager.inventory.Add(item);
            FreshSlot();
        }
    }

    // 인벤토리에서 아이템을 제거합니다.
    public void RemoveItem(string itemName)
    {
        // 정적 아이템 목록 Items 에서 name 속성이 매개변수와 동일한 아이템 객체 찾기
        Item item = Item.items.FirstOrDefault(item => item.name == itemName);

        GameManager.inventory.Remove(item);
        FreshSlot();
    }
}
