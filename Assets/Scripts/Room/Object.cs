using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Object : MonoBehaviour
{
    public CutScene cutScene;
    public Print print;
    public Monologue monologue_or_Dialogue;
    public Inventory inventory;
    public Image itemImage;
    public GameObject monologuePanel;
    public GameObject dialoguePanel;

    public void 아이템_획득(string itemName)
    {
        // 독백 & 대화 패널이 닫혀있을 때만 작동
        if (monologuePanel.active == false && dialoguePanel.active == false)
        {
            // 출력용 이미지를 현재 아이템의 이미지로 변경합니다. 아이템 리스트를 순회하여 찾습니다.
            foreach (var item in Item.items)
            {
                if (item.name == itemName)
                {
                    itemImage.sprite = item.sprite;
                }
            }

            // 아이템 이미지를 N초 동안 출력합니다.
            print.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
            cutScene.PopUpDownImage(0, 1.5f);

            // 아이템 획득 시 대사를 출력합니다.

            print.ObjectPrint(gameObject.name);

            // 인벤토리에 아이템을 추가합니다.
            inventory.AddItem(itemName);
        }
    }

    public void 대사_출력(string messageName)
    {
        // 독백 & 대화 패널이 닫혀있을 때만 작동
        if (monologuePanel.active == false && dialoguePanel.active == false)
        {
            monologue_or_Dialogue.PrintMonologue(messageName);
        }
    }
}
