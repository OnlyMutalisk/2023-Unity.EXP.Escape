using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    /// <summary>
    /// <br>확인 창을 팝업 합니다.</br>
    /// </summary>
    public void OpenConfirmation()
    {
        transform.Find("Confirmation").gameObject.SetActive(true);
    }

    /// <summary>
    /// <br>확인 창을 닫습니다.</br>
    /// </summary>
    public void CloseConfirmation()
    {
        transform.Find("Confirmation").gameObject.SetActive(false);
    }
}