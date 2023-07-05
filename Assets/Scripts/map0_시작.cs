using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.SceneManagement;

public class map0_시작 : MonoBehaviour
{
    /// <summary>
    /// <br>페이드 인 아웃 후 씬을 넘깁니다..</br>
    /// </summary>
    /// <returns></returns>
    IEnumerator FadeInOutNextScene()
    {
        텍스트_이펙트 textEffect = new 텍스트_이펙트();

        StartCoroutine(textEffect.페이드_인("FadeInOutText", 1, 60));
        yield return new WaitForSeconds(1.5f);

        yield return new WaitForSeconds(2);

        StartCoroutine(textEffect.페이드_아웃("FadeInOutText", 1, 60));
        yield return new WaitForSeconds(1.5f);

        SceneManager.LoadScene("map0_독백");
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FadeInOutNextScene());

        // 맵을 0 으로 변경합니다.
        Room.ChangeMap(0);
    }
}
