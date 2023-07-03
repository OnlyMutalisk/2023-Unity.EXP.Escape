using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Door : MonoBehaviour
{
    public Inventory inventory;

    public void OpenDoor()
    {
        if (inventory.HasKey())
        {
            Debug.Log("문이 열렸습니다");
            inventory.RemoveKey();
        }
        else
        {
            Debug.Log("Key가 없어서 문을 열 수 없습니다");
        }
    }
}
