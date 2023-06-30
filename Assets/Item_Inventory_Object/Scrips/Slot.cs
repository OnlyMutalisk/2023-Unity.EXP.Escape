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

                //�������� �̹����� ���� ���� 1�� �Ͽ� �̹��� ǥ��
                image.color = new Color(1, 1, 1, 1);
            }
            else
            {
                //item�� null�̸� �̹����� ���� ���� 0�� �Ͽ� �̹��� ����
                image.color = new Color(1, 1, 1, 0);
            }
        }
    }
}
