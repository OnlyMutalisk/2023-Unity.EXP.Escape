using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map0_C02 : MonoBehaviour
{
    public Print print;
    public Monologue dialogue;
    public CutScene cutScene;

    void Start()
    {
        StartCoroutine(CutScene02());
    }

    IEnumerator CutScene02()
    {
        yield return new WaitForSeconds(1.5f);

        print.ObjectPrint("map0_C02_컷신1");

        yield return new WaitForSeconds(4.5f);

        print.ObjectPrint("map0_C02_컷신2");

        yield return new WaitForSeconds(4.5f);

        dialogue.PrintMonologue("map0_C02_컷신3");
    }
}
