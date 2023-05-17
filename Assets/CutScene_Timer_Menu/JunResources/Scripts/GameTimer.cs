using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [SerializeField] private float GameTime = 60 * 60 + 60;
    public Text GameTimeText;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (GameManager.round != 3 && GameManager.round != 4)
        {
            GameTimeText.text = "99 : 99";
        }
        else if (!GameManager.IsPause)
        {
            GameTime -= Time.deltaTime;
            GameTimeText.text = (int)GameTime / 60 + " : " + (int)GameTime % 60;
            if ((int)GameTime==0)
            {
                GameOver();
            }
        }
        
    }

    public void TimerOff()
    {
        GameManager.IsPause = true;
    }

    public void TimerOn()
    {
        GameManager.IsPause = false;
    }

    //타이머가 다 되어서 게임오
    public void GameOver()
    {

    }
}
