using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    //아이템을 담을 리스트
    public List<Item> items;

    //slot의 부모 bag을 담을 곳
    [SerializeField]
    private Transform slotParent;

    //bag의 하위에 등록된 slot을 담을 곳
    [SerializeField]
    private Slot[] slots;

    private void OnValidate()
    {
        slots = slotParent.GetComponentsInChildren<Slot>();
    }

    private void Awake()
    {
        FreshSlot();
    }

    public void FreshSlot()
    {
        int i = 0;
        for (; i < items.Count && i < slots.Length; i++)
            slots[i].item = items[i];

        //빈 슬롯은 null 처리
        for (; i < slots.Length; i++)
            slots[i].item = null;
    }

    public void AddItem(Item _item)
    {
        if(items.Count < slots.Length)
        {
            items.Add(_item);
            FreshSlot();
        }
    }
}
