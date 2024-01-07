using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map1_N09 : MonoBehaviour
{
    public Monologue monologue;
    public Inventory inventory;
    public CutScene cutscene;

    /// <summary>
    /// <br> 현관문 접근 시 이벤트 입니다.</br>
    /// </summary>
    /// <returns></returns>
    public void Door()
    {
        // 최초 접근 시 이벤트 입니다.
        // 스크립트와 빈 도어락 이미지가 팝업됩니다.
        if (GameManager.boolMap1_N09_Flag == false)
        {
            GameManager.boolMap1_N09_Flag = true;
            monologue.PrintMonologue("map1_N09_현관문");

            return;
        }
        // 이후 접근 시 도어락 이미지가 팝업됩니다.
        else
        {
            cutscene.PopUpImage(GameManager.intMap1_N09_Doorlock, 0f);

            // 만약 건전지를 모두 끼웠다면
            if(GameManager.intMap1_N09_Doorlock == 4)
            {
                // map1 컷신으로 이동합니다.
            }
        }
    }

    // 인벤토리에 건전지가 있다면, 삭제하고 도어락에 장착합니다.
    public void Doorlock()
    {
        foreach (var item in GameManager.inventory)
        {
            if (item.name == "건전지")
            {
                inventory.RemoveItem("건전지");
                GameManager.intMap1_N09_Doorlock++;
                
                break;
            }
        }

        cutscene.PopDownImage(GameManager.intMap1_N09_Doorlock, 0f);
    }
}
