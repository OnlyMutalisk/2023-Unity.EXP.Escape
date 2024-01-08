using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class map2_N12 : MonoBehaviour
{
    public Monologue monologue;
    public Inventory inventory;

    public void 화장실()
    {
        System.Random 랜덤 = new System.Random();

        // 최초 상호작용 시 출력할 대사 입니다.
        if (GameManager.boolMap2_N12_Flag == false)
        {
            inventory.AddItem("헤어핀");
            inventory.AddItem("드릴");
            inventory.AddItem("망치");
            GameManager.boolMap2_N12_Flag = true;
            monologue.PrintMonologue("map2_N12_화장실");

            return;
        }

        // 헤어핀은 10% 확률로 문을 오픈
        if(inventory.currentSlotItemName == "헤어핀")
        {
            inventory.RemoveItem("헤어핀");

            if (랜덤.Next(1, 101) >= 90)
            {
                monologue.PrintMonologue("map2_N12_성공");
            }
            else
            {
                monologue.PrintMonologue("map2_N12_헤어핀");
            }
        }
        // 드릴은 30% 확률로 문을 오픈

        else if (inventory.currentSlotItemName == "드릴")
        {
            inventory.RemoveItem("드릴");

            if (랜덤.Next(1, 101) >= 70)
            {
                monologue.PrintMonologue("map2_N12_성공");
            }
            else
            {
                monologue.PrintMonologue("map2_N12_드릴");
            }
        }
        // 망치는 무조건 문을 오픈
        else if (inventory.currentSlotItemName == "망치")
        {
            inventory.RemoveItem("망치");
            monologue.PrintMonologue("map2_N12_성공");
        }
        else if (inventory.currentSlotItemName == "")
        {
            monologue.PrintMonologue("map2_N12_잡템");
        }
    }
}
