using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map0_C01 : MonoBehaviour
{
    public Print print;
    public Monologue dialogue;
    public CutScene cutScene;
    public AudioSource audioSource;

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

        dialogue.PrintMonologue("map0_C01_컷신3");
        cutScene.PopUpImage(0, 1f);
        audioSource.Play();

    }
}
