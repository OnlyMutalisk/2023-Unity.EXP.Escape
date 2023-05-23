using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomName : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(fadeInOut());
    }

    IEnumerator fadeInOut()
    {
        // 방 이름과 텍스트를 페이드 인 시킵니다.
        이미지_이펙트 imageEffect = new 이미지_이펙트();
        텍스트_이펙트 textEffect = new 텍스트_이펙트();
        StartCoroutine(imageEffect.페이드_인("RoomName", RoomSettings.floatRoomNameFadeInOutTime / 3, 60));
        StartCoroutine(textEffect.페이드_인("Text", RoomSettings.floatRoomNameFadeInOutTime / 3, 60));

        // 페이드 인 완료까지 기다립니다.
        yield return new WaitForSeconds((RoomSettings.floatRoomNameFadeInOutTime / 3) * 2);

        // 방 이름을 페이드 아웃 합니다.
        StartCoroutine(imageEffect.페이드_아웃("RoomName", RoomSettings.floatRoomNameFadeInOutTime / 3, 60));
        StartCoroutine(textEffect.페이드_아웃("Text", RoomSettings.floatRoomNameFadeInOutTime / 3, 60));

    }
}
