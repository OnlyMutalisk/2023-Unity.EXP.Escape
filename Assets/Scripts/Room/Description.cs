using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Description : MonoBehaviour
{
    public GameObject description;
    public GameObject name;
    public GameObject explain;
    public Inventory inventory;

    /// <summary>
    /// <br>Description 창을 지정한 인덱스의 슬롯 위치에서 엽니다.</br>
    /// </summary>
    public void Open(int index)
    {
        RectTransform rtDescription = description.GetComponent<RectTransform>();
        RectTransform rtName = name.GetComponent<RectTransform>();
        RectTransform rtExplain = explain.GetComponent<RectTransform>();
        Text tName = name.GetComponent<Text>();
        Text tExplain = explain.GetComponent<Text>();
        description.SetActive(true);

        // Name 과 Explain 의 텍스트를 변경합니다.
        try
        {
            tName.text = inventory.currentSlotItemName;
            tExplain.text = Items.설명[tName.text];
        }
        // 만약 아이템 혹은 그 설명이 존재하지 않는다면, 설명창을 닫습니다.
        catch (System.Exception)
        {
            description.SetActive(false);
            return;
        }

        float posX = 0;

        // 슬롯 인덱스에 맞춰서, Pos X 값을 변경합니다.
        switch (index)
        {
            case 0:
                posX = -343;
                break;
            case 1:
                posX = -172;
                break;
            case 2:
                posX = 0;
                break;
            case 3:
                posX = 172;
                break;
            case 4:
                posX = 343;
                break;
        }

        // 현재의 Y 포지션을 유지하면서 X 포지션을 변경합니다.
        rtDescription.anchoredPosition = new Vector2(posX, rtDescription.anchoredPosition.y);
    }
}
