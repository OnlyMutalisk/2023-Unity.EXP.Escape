using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class map0_C01 : MonoBehaviour
{
    // 컷신에서 사용될 오브젝트 입니다.
    public Print print;
    public Monologue monologue;
    public CutScene cutScene;

    void Start()
    {
        이미지_이펙트 imgEffect = new 이미지_이펙트();

        StartCoroutine(imgEffect.페이드_인("FadeOut", 1f, 30f));

        StartCoroutine(CutScene01());
    }

    IEnumerator CutScene01()
    {
        yield return new WaitForSeconds(1.5f);

        print.ObjectPrint("map0_C01_컷신1");

        yield return new WaitForSeconds(4.5f);

        print.ObjectPrint("map0_C01_컷신2");

        yield return new WaitForSeconds(4.5f);

        monologue.PrintMonologue("map0_C01_컷신3");
    }
}
