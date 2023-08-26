using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.UI;


public class CutScene : MonoBehaviour
{
    #region 내부 구현

    public RectTransform canvas;
    public RectTransform[] cutScenes;
    private GameObject[] images;
    public Image fadeInOutPanel;

    public void Start()
    {
        // 컷신의 크기를 캔버스에 맞게 규정합니다.
        SizeControl();

        // CutScene 오브젝트 하위의 모든 이미지를 가져옵니다.
        int length = gameObject.transform.childCount;

        images = new GameObject[length];

        for (int i = 0; i < length; i++)
        {
            images[i] = gameObject.transform.GetChild(i).gameObject;
        }
    }

    이미지_이펙트 imageEffect = new 이미지_이펙트();

    /// <summary>
    /// <br>인덱스 번호에 해당하는 이미지를 흔듭니다.</br>
    /// </summary>
    public IEnumerator CoroutineShakeImage(int index)
    {
        // 원래 위치값 originalPosition 저장
        Vector3 originalPosition = images[index].transform.position;
        Vector3 shakedPosition = originalPosition;

        // 이미지를 흔들 횟수
        int n = 7;

        // 이미지 흔들기
        for (int i = 0; i < n; i++)
        {
            // 랜덤 숫자 random 생성
            System.Random random = new System.Random();
            float randomNumberX = random.Next(-5, 5);
            float randomNumberY = random.Next(-5, 5);

            // 위치값 x, y 에 랜덤 숫자를 더함
            shakedPosition.x += randomNumberX;
            shakedPosition.y += randomNumberY;

            // 위치 갱신
            images[index].transform.position = shakedPosition;

            yield return new WaitForSeconds(0.04f);
        }

        // 변위 계산
        float gapX = originalPosition.x - shakedPosition.x;
        float gapY = originalPosition.y - shakedPosition.y;

        // 되돌림 당 움직임 계산
        float perX = gapX / n;
        float perY = gapY / n;

        // 이미지 되돌리기
        for (int i = 0; i < n; i++)
        {
            shakedPosition.x += perX;
            shakedPosition.y += perY;

            images[index].transform.position = shakedPosition;

            yield return new WaitForSeconds(0.02f);
        }
    }

    /// <summary>
    /// <br>인덱스 번호에 해당하는 이미지를 일정 초 동안 팝업 합니다.</br>
    /// </summary>
    public IEnumerator CoroutinePopUpDownImage(int index, float seconds)
    {
        StartCoroutine(imageEffect.페이드_인(images[index].name, seconds / 3, 60));

        yield return new WaitForSeconds((seconds / 3) * 2);

        StartCoroutine(imageEffect.페이드_아웃(images[index].name, seconds / 3, 60));
    }

    #endregion

    /// <summary>
    /// <br>인덱스 번호에 해당하는 이미지를 일정 초 동안 팝업 합니다.</br>
    /// <br>0 초로 설정하면 즉시 작동합니다.</br>
    /// </summary>
    public void PopUpImage(int index, float seconds)
    {
        images[index].active = true;

        StartCoroutine(imageEffect.페이드_인(images[index].name, seconds, 60));
    }

    /// <summary>
    /// <br>인덱스 번호에 해당하는 이미지를 일정 초 동안 팝업 & 팝다운 합니다.</br>
    /// </summary>
    public void PopUpDownImage(int index, float seconds)
    {
        images[index].active = true;

        StartCoroutine(CoroutinePopUpDownImage(index, seconds));
    }

    /// <summary>
    /// <br>인덱스 번호에 해당하는 이미지를 일정 초 동안 팝다운 합니다.</br>
    /// <br>0 초로 설정하면 즉시 작동합니다.</br>
    /// </summary>
    public void PopDownImage(int index, float seconds)
    {
        StartCoroutine(imageEffect.페이드_아웃(images[index].name, seconds, 60));
    }

    /// <summary>
    /// <br>인덱스 번호에 해당하는 이미지를 흔듭니다.</br>
    /// </summary>
    public void ShakeImage(int index)
    {
        StartCoroutine(CoroutineShakeImage(index));
    }

    /// <summary>
    /// <br>배경을 페이드 인 합니다.</br>
    /// </summary>
    public void FadeInBackground()
    {
        StartCoroutine(imageEffect.페이드_아웃(fadeInOutPanel.name, 1, 60));
    }

    /// <summary>
    /// <br>배경을 페이드 아웃 합니다.</br>
    /// </summary>
    public void FadeOutBackground()
    {
        fadeInOutPanel.gameObject.active = true;
        fadeInOutPanel.GetComponent<Image>().color = new Color(0, 0, 0, 0.8f);

        StartCoroutine(imageEffect.페이드_인(fadeInOutPanel.name, 1, 60));
    }

    /// <summary>
    /// <br>컷신의 사이즈를 캔버스에 맞게 조절합니다.</br>
    /// </summary>
    public void SizeControl()
    {
        float canvasWidth = canvas.sizeDelta.x;

        // 모든 컷신의 너비를 캔버스의 폭을 균등하게 분할한 값으로 매깁니다.
        foreach (RectTransform image in cutScenes)
        {
            image.sizeDelta = new Vector2(canvasWidth / cutScenes.Length, image.sizeDelta.y);
        }
    }
}
