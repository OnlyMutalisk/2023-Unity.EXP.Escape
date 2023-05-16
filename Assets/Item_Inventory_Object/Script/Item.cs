using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//아이템에 필요한 것
//획득 시 아이템 이름, 이미지, 간단한 설명 필요
[CreateAssetMenu]
public class Item : ScriptableObject
{
    //아이템의 정보를 담을 스크립트
    public string itemName; 
    public Sprite itemImage;
    public string itemText;
    public ItemType itemtype;

    public enum ItemType //소모품인지 아니면 계속 가지고 있을지 설정
    { 
        Use, Equip, Etc
    }


}
