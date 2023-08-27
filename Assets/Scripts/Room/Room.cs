using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Room : MonoBehaviour
{
    public CanvasScaler canvas;

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
        StartCoroutine(imageEffect.페이드_아웃("FadeInOut", GameManager.floatSceneFadeInOutTime, 60));

        // time 초 동안 대기 후, FadeInOut 오브젝트를 비활성화 시켜 다른 오브젝트를 가리지 않게 함.
        yield return new WaitForSeconds(GameManager.floatSceneFadeInOutTime * (float)1.5);
        gameObject.SetActive(false);
    }  

    /// <summary>
    /// <br>SFX 를 재생합니다. 확장자명을 제외한 파일의 이름을 변수로 사용합니다.</br>
    /// <br>사운드 파일은 반드시 Assets/Resources/Sounds/SFX 경로에 존재해야 합니다.</br>
    /// </summary>
    public static void SFX_재생(string soundName)
    {
        AudioSource audioSource = GameObject.Find("SFX Player").GetComponent<AudioSource>();
        audioSource.clip = Resources.Load<AudioClip>("Sounds/SFX/" + soundName);
        audioSource.Play();
    }

    /// <summary>
    /// <br>BGM 을 재생합니다. 확장자명을 제외한 파일의 이름을 변수로 사용합니다.</br>
    /// <br>사운드 파일은 반드시 Assets/Resources/Sounds/SFX 경로에 존재해야 합니다.</br>
    /// </summary>
    public static void BGM_재생(string soundName)
    {
        AudioSource audioSource = GameObject.Find("BGM Player").GetComponent<AudioSource>();
        audioSource.clip = Resources.Load<AudioClip>("Sounds/BGM/" + soundName);
        audioSource.Play();
    }

    /// <summary>
    /// <br>오브젝트의 위치를 보정하기 위해 캔버스 스케일러의 Match 값을 자동으로 조절합니다.</br>
    /// </summary>
    void MatchObjectSize()
    {
        // Default 해상도 비율
        float fixedAspectRatio = 16f / 9f;

        // 현재 해상도의 비율
        float currentAspectRatio = (float)Screen.width / (float)Screen.height;

        // 현재 해상도 가로 비율이 더 길 경우
        if (currentAspectRatio > fixedAspectRatio) canvas.matchWidthOrHeight = 1;

        // 현재 해상도의 세로 비율이 더 길 경우
        else if (currentAspectRatio < fixedAspectRatio) canvas.matchWidthOrHeight = 0;
    }

    void Awake()
    {
        // UI 및 오브젝트 위치를 보정합니다.
        MatchObjectSize();
    }

    void Start()
    {
        // 씬을 페이드 인 합니다.
        StartCoroutine(FadeIn());
    }
}
