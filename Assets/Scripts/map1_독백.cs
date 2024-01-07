using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class map1_독백 : MonoBehaviour
{
    public Monologue monologue;
    public GameObject panelButton;

    // 독백이 활성화 되면 flag 는 true 가 됨
    bool flag = false;

    void Start()
    {
        // 1.5 초 대기 후 독백 출력
        StartCoroutine(IEnumeratorPrintMonologue("map1_독백"));
    }

    IEnumerator IEnumeratorPrintMonologue(string messageName)
    {
        // 1.5 초 대기
        yield return new WaitForSeconds(1.5f);

        // 독백 출력 후 코루틴 종료
        monologue.PrintMonologue(messageName);
        flag = true;
        yield break;
    }

    void Update()
    {
        // 독백이 켜진 다음 꺼지면 씬 변경
        if (flag)
        {
            if (panelButton.active == false)
            {
                SceneManager.LoadScene("map1_N09");
                GameManager.sceneName = "map1_N09";
                GameTimer.TimerOn();
            }
        }
    }
}
