using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueBtn : MonoBehaviour
{
    public GameObject menu;

    public void ClickContinueButton()
    {
        GameTimer.TimerOn();
        menu.SetActive(false);
    }
}
