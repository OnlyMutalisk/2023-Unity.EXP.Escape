using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static List<Item> items = new List<Item>();
    [SerializeField] private Transform slotParent;
    private Slot[] slots;

//    private bool keyUsed = false;

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
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < items.Count)
                slots[i].UpdateSlot(items[i]);
            else
                slots[i].UpdateSlot(null);
        }
    }

    public void AddItem(Item item)
    {
        if (items.Count < slots.Length)
        {
            items.Add(item);
            FreshSlot();
        }
    }

    public void RemoveItem(Item item)
    {
        items.Remove(item);
        FreshSlot();
    }

    public bool HasKey()
    {
        return items.Exists(item => item.itemName == "Key");
    }

    public void RemoveKey()
    {
        Item key = items.Find(item => item.itemName == "Key");
        if (key != null)
        {
            items.Remove(key);
            FreshSlot();
        }
    }

}
