using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor.EditorTools;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor.VersionControl;

public class Room : MonoBehaviour
{
    /// <summary>
    /// <br>씬을 페이드 인 시킵니다.</br>
    /// </summary>
    public IEnumerator FadeIn()
    {
        // 검은 화면 오브젝트인 "FadeInOut" 를 페이드 아웃 하여, 씬을 페이드 인 시킴
        // FadeInOut 오브젝트 선택
        GameObject gameObject = GameObject.Find("FadeInOut");

        // FadeInOut 오브젝트 활성화
        gameObject.SetActive(true);

        // 이미지 컴포넌트의 Color 값을 건드려, 검은 화면으로 만듦.
        gameObject.GetComponent<Image>().color = new Color(0, 0, 0, 1);

        // 이제 FadeInOut 오브젝트를 RoomSettings 에 정의된 시간 동안 페이드 아웃
        이미지_이펙트 imageEffect = new 이미지_이펙트();
        StartCoroutine(imageEffect.페이드_아웃("FadeInOut", RoomSettings.floatSceneFadeInOutTime, 60));

        // time 초 동안 대기 후, FadeInOut 오브젝트를 비활성화 시켜 다른 오브젝트를 가리지 않게 함.
        yield return new WaitForSeconds(RoomSettings.floatSceneFadeInOutTime * (float)1.5);
        gameObject.SetActive(false);
    }

    /// <summary>
    /// <br>맵을 변경합니다.</br>
    /// </summary>
    public void ChangeMap(int 맵_번호)
    {
        // 현재 맵 번호를 갱신 합니다.
        GameManager.map = 맵_번호;

        // BGM 을 변경합니다.

    }

    void Start()
    {
        // 씬을 페이드 인 합니다.
        StartCoroutine(FadeIn());
    }
}
