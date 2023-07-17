using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Object : MonoBehaviour
{
    // 인스펙터에서 연결할 오디오소스 오브젝트 입니다.
    public AudioSource audioSource;
    public CutScene cutScene;
    public Print print;
    public Inventory inventory;
    public Image itemImage;

    // 오브젝트 클릭 시 기본 작동 코드 입니다.
    public void 오브젝트_클릭()
    {
        audioSource.clip = Resources.Load<AudioClip>("Sounds/Object/" + gameObject.name);
        audioSource.Play();
    }

    public void 아이템_획득(string itemName)
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
