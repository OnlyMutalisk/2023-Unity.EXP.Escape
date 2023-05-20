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
        StartCoroutine(FadeIn());

        // 씬을 페이드 아웃 합니다.
        // fadeInOut.FadeOut();

    }

    #region 내부 구현 (private)

    private IEnumerator FadeIn()
    {
        // 검은 화면 오브젝트인 "FadeInOut" 를 페이드 아웃 하여, 씬을 페이드 인 시킴
        // FadeInOut 오브젝트 선택
        GameObject gameObject = GameObject.Find("FadeInOut");

        // FadeInOut 오브젝트 활성화
        gameObject.SetActive(true);

        // 이미지 컴포넌트의 Color 값을 건드려, 검은 화면으로 만듦.
        gameObject.GetComponent<Image>().color = new Color(0, 0, 0, 1);

        // 이제 FadeInOut 오브젝트를 time 초 동안 페이드 아웃
        float time = 1;
        이미지_이펙트 imageEffect = new 이미지_이펙트();
        StartCoroutine(imageEffect.페이드_아웃("FadeInOut", time, 60));

        // time 초 동안 대기 후, FadeInOut 오브젝트를 비활성화 시켜 다른 오브젝트를 가리지 않게 함.
        yield return new WaitForSeconds(time * (float)2);
        gameObject.SetActive(false);
    }

    #endregion
}
