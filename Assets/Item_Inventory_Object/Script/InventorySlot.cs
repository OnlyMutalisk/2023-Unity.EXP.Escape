using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//인벤토리 슬롯의 아이템 이미지와 관련 내용을 띄운다.
//슬롯을 비우는 함수
public class InventorySlot : MonoBehaviour
{

    public Image image;
    public Text itemName;
    public GameObject selected_item;
 

    public void Additem(Item _item)
    {
        //itemName.text = _item.name;
        image.sprite = _item.itemImage;
        //itemDescription.text = _item.itemText;

    }


}
