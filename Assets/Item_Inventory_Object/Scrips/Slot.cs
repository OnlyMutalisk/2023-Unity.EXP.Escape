using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private Button door;
    private Inventory inventory;
    public Item item;

    private void Awake()
    {
        inventory = FindObjectOfType<Inventory>();
    }

    


    public void UpdateSlot(Item newItem)
    {
        item = newItem;
        if (item != null)
        {
            image.sprite = item.itemImage;
            image.color = Color.white;
        }
        else
        {
            image.sprite = null;
            image.color = Color.clear;
        }
    }

    
}
