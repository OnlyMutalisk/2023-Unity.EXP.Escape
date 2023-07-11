using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;
using System.Reflection;
using UnityEngine.SceneManagement;
using UnityEditor;

public class Monologue : MonoBehaviour
{

    #region 내부 구현

    // 코루틴 동기화 플래그 입니다.
    public bool boolCoroutineSynchronizeFlag = true;
    public int intSkipFlag = 0;

    // 독백 이벤트 감지용 플래그 입니다.
    public static int monologueEventFlag = 0;

    // 인스펙터에서 연결합니다.
    public Text componentText;
    public GameObject gameObjectPanelButton;
    public GameObject gameObjectArrow;
    public MonologueEvent monologueEvent;

    // 독백의 이터레이터 입니다.
    public int intCount;

    // 각 글자 시간 간격을 설정 합니다.
    private float floatTypingSpeed = 0.1f;

    // 독백 덩어리를 출력합니다.
    private IEnumerator IEnumeratorPrintMonologue(LinkedList<string> 독백)
    {
        // 코루틴 접근을 차단합니다.
        boolCoroutineSynchronizeFlag = false;

        // 메시지 패널을 활성화 합니다.
        gameObjectPanelButton.SetActive(true);

        // 아직 출력돼야 할 메시지가 남았다면
        if (intCount < 독백.Count)
        {
            // 독백 이벤트를 발생시킵니다.
            monologueEvent.Event();

            // 독백 이벤트 플래그를 갱신합니다.
            monologueEventFlag++;

            // 텍스트를 초기화 합니다.
            componentText.text = "";

            // Arrow 를 비활성화 합니다.
            gameObjectArrow.SetActive(false);

            // 글자 수를 0 부터 점점 늘려갑니다.
            int characterIndex = 0;

            // 모든 글자가 출력될 때 까지 반복합니다.
            while (characterIndex < 독백.First.Value.Length)
            {
                // 첫 터치 시 출력은
                if (intSkipFlag == 1)
                {
                    // 글자 갯수를 하나 더 늘립니다.
                    componentText.text += 독백.First.Value[characterIndex];
                    characterIndex++;

                    // 글자 간 간격 시간 만큼 대기합니다.
                    yield return new WaitForSeconds(floatTypingSpeed);
                }
                // 두번째 터치 시 부터는
                else if (intSkipFlag >= 2)
                {
                    // 모든 글자를 한번에 출력합니다.
                    componentText.text = 독백.First.Value;
                    break;
                }
            }

            // 사용한 대사를 지우고, 리스트의 마지막에 다시 추가해줍니다.
            독백.AddLast(독백.First.Value);
            독백.RemoveFirst();

            // Arrow 를 활성화 합니다.
            gameObjectArrow.SetActive(true);

            // 스킵 플래그를 초기화 합니다.
            intSkipFlag = 0;

            // 이터레이터를 다음으로 옮깁니다.
            intCount++;
        }
        // 모두 다 출력을 완료 했다면
        else
        {
            // 독백 이벤트 플래그를 초기화 합니다.
            monologueEventFlag = 0;

            // 독백 패널을 닫습니다.
            gameObjectPanelButton.SetActive(false);

            // 스킵 플래그를 초기화 합니다.
            intSkipFlag = 0;

            // 이터레이터를 초기화 합니다.
            intCount = 0;
        }

        // 코루틴 접근을 허용합니다.
        boolCoroutineSynchronizeFlag = true;
    }

    // 아이템 스크립트를 출력합니다.
    private IEnumerator IEnumeratorPrintItemScript(LinkedList<string> 독백)
    {
        // 코루틴 접근을 차단합니다.
        boolCoroutineSynchronizeFlag = false;

        // 메시지 패널을 활성화 합니다.
        gameObjectPanelButton.SetActive(true);

        // 아직 출력돼야 할 메시지가 남았다면
        if (intCount < 독백.Count)
        {
            // 텍스트를 초기화 합니다.
            componentText.text = "";

            // Arrow 를 비활성화 합니다.
            gameObjectArrow.SetActive(false);

            // 글자 수를 0 부터 점점 늘려갑니다.
            int characterIndex = 0;

            // 모든 글자가 출력될 때 까지 반복합니다.
            while (characterIndex < 독백.First.Value.Length)
            {
                // 첫 터치 시 출력은
                if (intSkipFlag == 1)
                {
                    // 글자 갯수를 하나 더 늘립니다.
                    componentText.text += 독백.First.Value[characterIndex];
                    characterIndex++;

                    // 글자 간 간격 시간 만큼 대기합니다.
                    yield return new WaitForSeconds(floatTypingSpeed);
                }
                // 두번째 터치 시 부터는
                else if (intSkipFlag >= 2)
                {
                    // 모든 글자를 한번에 출력합니다.
                    componentText.text = 독백.First.Value;
                    break;
                }
            }

            // 사용한 대사를 지우고, 리스트의 마지막에 다시 추가해줍니다.
            독백.AddLast(독백.First.Value);
            독백.RemoveFirst();

            // Arrow 를 활성화 합니다.
            gameObjectArrow.SetActive(true);

            // 스킵 플래그를 초기화 합니다.
            intSkipFlag = 0;

            // 이터레이터를 다음으로 옮깁니다.
            intCount++;
        }
        // 모두 다 출력을 완료 했다면
        else
        {
            // 독백 패널을 닫습니다.
            gameObjectPanelButton.SetActive(false);

            // 스킵 플래그를 초기화 합니다.
            intSkipFlag = 0;

            // 이터레이터를 초기화 합니다.
            intCount = 0;
        }

        // 코루틴 접근을 허용합니다.
        boolCoroutineSynchronizeFlag = true;
    }

    #endregion

    /// <summary>
    /// <br>현재 씬에 해당하는 독백 메시지를 순차 출력합니다.</br>
    /// </summary>
    public void PrintMonologue()
    {
        // 현재 씬의 이름을 가져옵니다.
        string messageName = SceneManager.GetActiveScene().name;

        // 리플렉션을 통해 현재 씬 이름에 해당하는 독백 메시지에 접근합니다.
        Messages messages = new Messages();
        FieldInfo fieldInfo = typeof(Messages).GetField(messageName);
        LinkedList<string> message = fieldInfo.GetValue(messages) as LinkedList<string>;

        intSkipFlag++;

        if (boolCoroutineSynchronizeFlag == true)
        {
            StartCoroutine(IEnumeratorPrintMonologue(message));
        }
    }
}
