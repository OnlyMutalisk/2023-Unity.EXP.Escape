using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class 이미지_이펙트
{
    /// <summary>
    /// <br>IEnumerator 형식은 반드시 Monobehavior.StartCoroutine(IEnumerator) 로 사용해야 합니다.</br>
    /// <br>오브젝트를 지정된 시간동안 기본 투명도까지 점점 선명하게 만들어 줍니다.</br>
    /// <br>1 초 마다 "초당 조정 횟수" 만큼 투명도를 변화시켜 부드럽게 표현할 수 있습니다.</br>
    /// <br>초당 조정 횟수는 30 이상을 추천합니다.</br>
    /// </summary>
    public IEnumerator 페이드_인(string 오브젝트_이름, float 걸리는_시간_초단위, float 초당_조정_횟수)
    {
        // 적용 대상 게임 오브젝트를 지정합니다.
        GameObject gameObject = GameObject.Find(오브젝트_이름);

        // 일단 원래 컬러를 저장해둡니다.
        Color originalColor = gameObject.GetComponent<Image>().color;

        // 오브젝트를 투명하게 만듭니다. 즉, color 의 a (alpha, 투명도) 값을 0 으로 (0 = 최소값, 1 = 최대값) 바꿔야 합니다.
        // Image 컴포넌트의 color 구조체는 Constant 이므로, 새로 만들어서 바꿔줘야 합니다.
        gameObject.GetComponent<Image>().color = new Color(originalColor.r, originalColor.g, originalColor.b, 0);

        // 조정할 총 a 값 견적
        float alphaRange = originalColor.a;

        // 초당 60 번 조정
        float setPerSecond = 초당_조정_횟수;

        // 총 조정 횟수 (총 시간 (초) * 초당 60 번)
        float fullSetCount = 걸리는_시간_초단위 * setPerSecond;

        // 각 조정 당 변경 할 a 값 (총 a 값 견적 / 총 조정 횟수)
        float alphaPerSet = alphaRange / fullSetCount;

        // 각 조정 당 걸릴 시간 (총 걸릴 시간 / 총 조정 횟수)
        float timePerSet = 걸리는_시간_초단위 / fullSetCount;

        // 오브젝트를 다시 밝아지게 해야 합니다.
        // 즉, a 값을 원래 값 까지 높여서 다시 잘 보이게 만들어야 합니다.
        // N 초 동안 자연스럽게 a 값을 높일 반복문을 구현합니다.    
        while (true)
        {
            // a 값 조정한 Color 구조체 생성
            Color color = gameObject.GetComponent<Image>().color;
            color.a += alphaPerSet;

            // a 값이 원래 값 보다 커지면...
            if (color.a > originalColor.a)
            {
                // a 값을 원래 값으로 바꾸고
                color.a = originalColor.a;

                // 조정된 Color 구조체를 원래 값에 삽입
                gameObject.GetComponent<Image>().color = color;

                // 코루틴 반복 종료
                break;
            }

            // 조정된 Color 구조체를 원래 값에 삽입
            gameObject.GetComponent<Image>().color = color;

            // 다음 조정 까지 스레드 권리 메인에게 양보
            yield return new WaitForSeconds(timePerSet);
        }
    }

    /// <summary>
    /// <br>IEnumerator 형식은 반드시 Monobehavior.StartCoroutine(IEnumerator) 로 사용해야 합니다.</br>
    /// <br>오브젝트를 지정된 시간동안 완전 투명해질 때 까지 점점 투명하게 만들어 줍니다.</br>
    /// <br>1 초 마다 "초당 조정 횟수" 만큼 투명도를 변화시켜 부드럽게 표현할 수 있습니다.</br>
    /// <br>초당 조정 횟수는 30 이상을 추천합니다.</br>
    /// </summary> 
    public IEnumerator 페이드_아웃(string 오브젝트_이름, float 걸리는_시간_초단위, float 초당_조정_횟수)
    {
        // 적용 대상 게임 오브젝트를 지정합니다.
        GameObject gameObject = GameObject.Find(오브젝트_이름);

        // 일단 원래 컬러를 저장해둡니다.
        Color originalColor = gameObject.GetComponent<Image>().color;

        // 조정할 총 a 값 견적
        float alphaRange = originalColor.a;

        // 초당 60 번 조정
        float setPerSecond = 초당_조정_횟수;

        // 총 조정 횟수 (총 시간 (초) * 초당 60 번)
        float fullSetCount = 걸리는_시간_초단위 * setPerSecond;

        // 각 조정 당 변경 할 a 값 (총 a 값 견적 / 총 조정 횟수)
        float alphaPerSet = alphaRange / fullSetCount;

        // 각 조정 당 걸릴 시간 (총 걸릴 시간 / 총 조정 횟수)
        float timePerSet = 걸리는_시간_초단위 / fullSetCount;

        // 오브젝트를 점점 투명하게 해야 합니다. 즉, color 의 a (alpha, 투명도) 값을 0 으로 (0 = 최소값, 1 = 최대값) 바꿔야 합니다.
        // 즉, a 값을 0 까지 줄여서 점점 투명해지게 해야 합니다.
        // N 초 동안 자연스럽게 a 값을 줄일 반복문을 구현합니다.    
        while (true)
        {
            // a 값 조정한 Color 구조체 생성
            Color color = gameObject.GetComponent<Image>().color;
            color.a -= alphaPerSet;

            // a 값이 0 보다 작아지면...
            if (color.a < 0)
            {
                // a 값을 0 으로 바꾸고
                color.a = 0;

                // 조정된 Color 구조체를 원래 값에 삽입
                gameObject.GetComponent<Image>().color = color;

                // 코루틴 반복 종료
                break;
            }

            // 조정된 Color 구조체를 원래 값에 삽입
            gameObject.GetComponent<Image>().color = color;

            // 다음 조정 까지 스레드 권리 메인에게 양보
            yield return new WaitForSeconds(timePerSet);
        }
    }
}