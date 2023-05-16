using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//아이템 획득 시 획득 정보 출력
public class ItemInfo : MonoBehaviour
{
    public Text itemDescription;
    public void ShowItemInfo(Item _item)
    {
        itemDescription.text = _item.itemText;
        //Debug.Log(itemDescription+ "을 획득했다.");
    }

}
