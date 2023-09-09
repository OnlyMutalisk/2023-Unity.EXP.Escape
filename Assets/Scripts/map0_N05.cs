using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class map0_N05 : MonoBehaviour
{
    // 인스펙터에서 연결 할 오브젝트 입니다.
    public Image image;
    public Sprite sprite;
    public Object washingMachine;

    // 배경 이미지를 세탁기가 열린 모습으로 변경합니다.
    public void ChangeImage()
    {
        image.sprite = sprite;
    }

    // 세탁기 클릭 시 발생할 이벤트 입니다.
    public void ClickWashingMachine()
    {
        // 침실창문에 접근해야만 세탁기 클릭 이벤트가 작동합니다.
        if (GameManager.boolMap0_N04_Flag == false)
        {
            ChangeImage();
            washingMachine.대사_출력("map0_N05_세탁기");
        }
    }
}
