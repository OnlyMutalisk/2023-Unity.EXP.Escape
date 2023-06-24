using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;
using System.Reflection;
using UnityEditor;

public class Print : MonoBehaviour
{
    #region 내부 구현 (private)

    // 코루틴의 임계영역용 플래그 입니다.
    bool flag = true;

    // 패널, 타이틀, 메시지 Color
    Color originalPanelColor = new Color(0, 0, 0, 0.53f);
    Color originalTitleColor = new Color(255, 255, 255, 1);
    Color originalMessageColor = new Color(255, 255, 255, 1);

    private ObjectMessage Load(string objectName)
    {
        // 리플렉션 (변수명으로 속성 접근) 을 위한 코드입니다.
        // 접근할 클래스를 지정합니다.
        Type type = typeof(Messages);

        // 클래스의 필드를 FieldInfo 형태로 접근합니다.
        FieldInfo testObjectField = type.GetField(objectName);

        // 접근한 필드를, 원래 형태로 돌려줍니다.
        ObjectMessage testObject = (ObjectMessage)testObjectField.GetValue(null);

        return testObject;
    }

    public IEnumerator CoroutineObjectPrint(string title, string message, float time)
    {
        flag = false;

        // 패널, 타이틀, 메시지 오브젝트 할당
        GameObject gameObjectPanel = gameObject.transform.Find("Panel").gameObject;
        GameObject gameObjectTitle = gameObject.transform.Find("Title").gameObject;
        GameObject gameObjectMessage = gameObject.transform.Find("Message").gameObject;

        // 패널, 타이틀, 메시지 활성화
        gameObjectPanel.SetActive(true);
        gameObjectTitle.SetActive(true);
        gameObjectMessage.SetActive(true);

        // 패널, 타이틀, 메시지 Color 초기값 복원
        gameObjectPanel.GetComponent<Image>().color = originalPanelColor;
        gameObjectTitle.GetComponent<Text>().color = originalTitleColor;
        gameObjectMessage.GetComponent<Text>().color = originalMessageColor;

        // Title.Text 편집
        gameObjectTitle.GetComponent<Text>().text = title;

        // Message.Text 편집
        gameObjectMessage.GetComponent<Text>().text = message;

        // Panel, Title, Message 오브젝트 페이드 인
        float fadeTime = time / 3;
        이미지_이펙트 imageEffect = new 이미지_이펙트();
        텍스트_이펙트 textEffect = new 텍스트_이펙트();

        StartCoroutine(imageEffect.페이드_인("Panel", fadeTime, 60));
        StartCoroutine(textEffect.페이드_인("Title", fadeTime, 60));
        StartCoroutine(textEffect.페이드_인("Message", fadeTime, 60));

        // fadeTime 초 대기
        yield return new WaitForSeconds(fadeTime * 2);
        // time - fadeTime 초 대기
        yield return new WaitForSeconds(time - fadeTime);

        // Print 오브젝트 페이드 아웃
        StartCoroutine(imageEffect.페이드_아웃("Panel", fadeTime, 60));
        StartCoroutine(textEffect.페이드_아웃("Title", fadeTime, 60));
        StartCoroutine(textEffect.페이드_아웃("Message", fadeTime, 60));

        // fadeTime 초 대기
        yield return new WaitForSeconds(fadeTime * 2);

        // 패널, 타이틀, 메시지 비활성화
        gameObjectPanel.SetActive(false);
        gameObjectTitle.SetActive(false);
        gameObjectMessage.SetActive(false);

        flag = true;
    }

    #endregion

    /// <summary>
    /// <br>다음 형식으로 메시지가 출력됩니다.</br>
    /// <br><title></br>
    /// <br>message</br>
    /// </summary>
    public void ObjectPrint(string objectName)
    {
        if (flag == true)
        {
            string a = gameObject.name;
            // 출력할 title, message, time 을 가지고 있는 객체를 가져옵니다.
            // 오브젝트의 이름과 동일한 객체를 가져옵니다.
            ObjectMessage objectMessage = Load(objectName);

            // 필드의 값을 사용하여, 메시지를 출력합니다.
            StartCoroutine(CoroutineObjectPrint(objectMessage.title, objectMessage.message, objectMessage.time));
        }
    }
}
