using System.Collections;
using System.Collections.Generic;
using UnityEditor.EditorTools;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Room : MonoBehaviour
{
    public string roomName;
    // public RoomObject roomObject; 서브 프로그래머 구현 예정
    // public CutScene roomCutScene; 서브 프로그래머 구현 예정
    public AudioSource moveEffectSound;
    // 퀵슬롯

    // 방 입장 효과음 재생()
    // 상호작용 대사 출력() : 아이템 획득시 이미지도 출력
    // 독백 대사 출력() : 캐릭터 컷신 이미지 팝업
    // 퀵슬롯() : 로드뷰 & 인벤토리 & 메뉴 & 로드뷰 ON / OFF
    // 방 나감 fade out()

    private void Start()
    {
        // moveEffectSound 재생

        // 상호작용 

        // 씬을 페이드 인 합니다.
        FadeIn();
    }

    #region 내부 구현 (private)

    private void FadeIn()
    {
        // 검은 화면 오브젝트인 "FadeIn" 를 페이드 아웃하여, 씬을 페이드 인 시킴
        // FadeIn 오브젝트 선택
        GameObject gameObject = GameObject.Find("FadeIn");

        // 이미지 컴포넌트의 Color 값을 건드려, 검은 화면으로 만듦.
        gameObject.GetComponent<Image>().color = new Color(0, 0, 0, 1);

        // 이제 FadeIn 오브젝트를 페이드 아웃
        이미지_이펙트 imageEffect = new 이미지_이펙트();
        StartCoroutine(imageEffect.페이드_아웃("FadeIn", 2, 60));
    }

    #endregion
}
