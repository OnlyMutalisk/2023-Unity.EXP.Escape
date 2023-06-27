using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickMenu : MonoBehaviour
{
    // 인스펙터에서 연결할 오브젝트 입니다.
    public GameObject[] roadView;
    public GameObject inventory;
    public GameObject menu;

    // 인스펙터에서 연결할 효과음 입니다.
    public AudioSource audioInventoryOpen;
    public AudioSource audioInventoryClose;
    public AudioSource audioRoadView;
    public AudioSource audioMenu;

    /// <summary>
    /// <br>로드뷰의 On / Off 상태를 변환합니다.</br>
    /// </summary>
    public void RoadViewOnOffControl()
    {
        // 모든 로드뷰에 대하여,
        for (int i = 0; i < roadView.Length; i++)
        {
            // 로드뷰가 켜져 있다면
            if (roadView[i].active)
            {
                // 로드 뷰를 끕니다.
                roadView[i].SetActive(false);

                // 로드뷰 효과음을 재생합니다.
                audioRoadView.Play();
            }
            // 로드뷰가 꺼져 있다면
            else
            {
                // 로드뷰를 켭니다.
                roadView[i].SetActive(true);

                // 로드뷰 효과음을 재생합니다.
                audioRoadView.Play();
            }
        }
    }

    /// <summary>
    /// <br>인벤토리의 On / Off 상태를 변환합니다.</br>
    /// </summary>
    public void InventoryOnOffControl()
    {
        // 인벤토리가 켜져 있다면
        if (inventory.active)
        {
            // 인벤토리를 끕니다.
            inventory.SetActive(false);

            // 인벤토리 닫기 효과음을 재생합니다.
            audioInventoryClose.Play();
        }
        // 인벤토리가 꺼져 있다면
        else
        {
            // 인벤토리를 켭니다.
            inventory.SetActive(true);

            // 인벤토리 열기 효과음을 재생합니다.
            audioInventoryOpen.Play();
        }
    }

    /// <summary>
    /// <br>메뉴의 On / Off 상태를 변환합니다.</br>
    /// </summary>
    public void MenuOnOffControl()
    {
        // 메뉴가 켜져 있다면
        if (menu.active)
        {
            // 메뉴를 끕니다.
            menu.SetActive(false);

            // 메뉴 효과음을 재생합니다.
            audioMenu.Play();
        }
        // 메뉴가 꺼져 있다면
        else
        {
            // 메뉴를 켭니다.
            menu.SetActive(true);

            // 메뉴 효과음을 재생합니다.
            audioMenu.Play();
        }
    }
}
