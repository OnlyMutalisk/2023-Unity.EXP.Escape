using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class map0_N05 : MonoBehaviour
{
    // 인스펙터에서 연결 할 오브젝트 입니다.
    public Image image;
    public Sprite sprite;

    // 배경 이미지를 세탁기가 열린 모습으로 변경합니다.
    public void ChangeImage()
    {
        image.sprite = sprite;
    }
}
