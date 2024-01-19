using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    [SerializeField] private Image image;
    private Inventory inventory;
    private Sprite defaultSprite;
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
            image.sprite = item.sprite;
        }
        else
        {
            image.sprite = Resources.Load<Sprite>("Images/UI/장비창");
        }
    }

    
}
