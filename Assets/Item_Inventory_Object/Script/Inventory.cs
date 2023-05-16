using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//슬롯에서 아이템 누르면 테두리 색상 변화 필요
//아이템 얻으면 순서대로 인벤토리에 저장되기
//처음에는 remove 필요함
//건전지 같은 아이템은 소모품이므로 이를 따로 저장하기(item cs에서 다룹니다)
public class Inventory : MonoBehaviour
{

    private InventorySlot[] slots;
    private List<Item> inventoryitemList;   //플레이어가 소지한 아이템


    //public Text Description_Text;    //부연 설명
    public Transform tf; // slot 부모 객체

    public GameObject go;//인벤토리 활성화 비활성화;
    public GameObject[] selectedItemPanel; //선택된 아이템 위 펜넬을 바꿈

    private int selectedItem;    //어떤 아이템을 선택했는지

    private bool activated = false; //인벤토리 활성화시 true;
    private bool ItemActivated; //아이템 활성화시 true;

    private WaitForSeconds waitTime = new WaitForSeconds(0.01f);




    void Start()
    {
        inventoryitemList = new List<Item>();

        slots = tf.GetComponentsInChildren<InventorySlot>();    //자식 객체들의 속성이 동일해짐
    
    }

    public void ShowItem()
    {
        selectedItem = 0;
        for(int i = 0; i < slots.Length; i++) //인벤토리에 보여줌
        {
            slots[i].gameObject.SetActive(true);
            slots[i].Additem(inventoryitemList[i]);
        }
        StartCoroutine(SelectedItemPanelEffectCoroutin());

        
    }

    public void SelectedItemPanel()
    {
        StopAllCoroutines();
        Color color = selectedItemPanel[selectedItem].GetComponent<Image>().color;
        color.a = 0f;
        for(int i = 0; i <selectedItemPanel.Length; i++)
        {
            selectedItemPanel[i].GetComponent<Image>().color = color;
        }
        //이제 선택된 탭이 빛나게

    }

    IEnumerator SelectedItemPanelEffectCoroutin()
    {
        while (ItemActivated)
        {
            Color color = selectedItemPanel[0].GetComponent<Image>().color;
            while(color.a < 0.5f)
            {
                color.a += 0.03f;
                selectedItemPanel[selectedItem].GetComponent<Image>().color = color;
                yield return waitTime;
            }
            while (color.a > 0.5f)
            {
                color.a = 0.03f;
                selectedItemPanel[selectedItem].GetComponent<Image>().color = color;
                yield return waitTime; 
            }

           
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I)) //i누르면 인벤토리 나옴
        {
            activated = !activated; //true면 false

            //여기에 추가로 인벤토리 열면 나오는 sound 설정 할 수 있음

            if (activated)
            {
                go.SetActive(true);
                ItemActivated = true;
                ShowItem();


                //오른쪽 방향키 누르면 
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    ShowItem();
                    selectedItem++;

                }
                else if(Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    ShowItem();
                    selectedItem--;
                }
            }
        }
        
    }

}
