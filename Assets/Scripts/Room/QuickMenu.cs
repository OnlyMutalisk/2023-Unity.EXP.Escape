using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuickMenu : MonoBehaviour
{
    #region 내부 구현

    private GameObject[] roadView;

    // RoadViews 오브젝트 하위의 모든 로드뷰를 가져옵니다.
    public void Start()
    {
        int length = roadViews.transform.childCount;

        roadView = new GameObject[length];

        for (int i = 0; i < length; i++)
        {
            roadView[i] = roadViews.transform.GetChild(i).gameObject;
        }
    }

    #endregion

    // 인스펙터에서 연결할 오브젝트 입니다.
    public GameObject roadViews;
    public GameObject inventory;

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
            }
            // 로드뷰가 꺼져 있다면
            else
            {
                // 로드뷰를 켭니다.
                roadView[i].SetActive(true);
            }
        }

        // 인벤토리를 끕니다.
        inventory.SetActive(false);
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
        }
        // 인벤토리가 꺼져 있다면
        else
        {
            // 인벤토리를 켭니다.
            inventory.SetActive(true);
        }

        // 모든 로드뷰에 대하여,
        for (int i = 0; i < roadView.Length; i++)
        {
            // 로드 뷰를 끕니다.
            roadView[i].SetActive(false);
        }
    }

    /// <summary>
    /// <br>메뉴의 On / Off 상태를 변환합니다.</br>
    /// </summary>
    public void MenuOnOffControl()
    {
        GameObject gameObjectMenu = GameObject.Find("CanvasDontDestroy").transform.GetChild(0).gameObject;

        // 메뉴가 켜져 있다면
        if (gameObjectMenu.active)
        {
            // 메뉴를 끕니다.
            gameObjectMenu.SetActive(false);
        }
        // 메뉴가 꺼져 있다면
        else
        {
            // 메뉴를 켭니다.
            gameObjectMenu.SetActive(true);
        }

        // 인벤토리를 끕니다.
        inventory.SetActive(false);

        // 모든 로드뷰에 대하여,
        for (int i = 0; i < roadView.Length; i++)
        {
            // 로드 뷰를 끕니다.
            roadView[i].SetActive(false);
        }
    }
}
