using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    [SerializeField] Image image;

    private Item _item;
    public Item item
    {
        get { return _item; }
        set
        {
            _item = value;
            if(_item != null)
            {
                image.sprite = item.itemImage;

                //아이템의 이미지의 알파 값을 1로 하여 이미지 표시
                image.color = new Color(1, 1, 1, 1);
            }
            else
            {
                //item이 null이면 이미지의 알파 값을 0로 하여 이미지 숨김
                image.color = new Color(1, 1, 1, 0);
            }
        }
    }
}
