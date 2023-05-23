using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryButton : MonoBehaviour
{
    public GameObject inventoryPanel; // 인벤토리 패널을 연결할 게임 오브젝트 변수
 

    private bool isInventoryOpen = false; // 인벤토리 패널이 열려 있는지 여부를 나타내는 변수

   
    public void ToggleInventory()
    {
        isInventoryOpen = !isInventoryOpen;

        //인벤토리 상태 변경
        inventoryPanel.SetActive(isInventoryOpen);
    }
}
