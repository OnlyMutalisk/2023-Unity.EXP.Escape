using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    public string roomName;
    public AudioSource BGM;
    // public RoomObject roomObject; 서브 프로그래머 구현 예정
    // public CutScene roomCutScene; 서브 프로그래머 구현 예정
    public List<string>[] moveRoomName;
    public AudioSource moveEffectSound;
    public GameObject loadView;

    #region 내부 구현 (private)

    //public Camera camera;
    //public Canvas canvas;
    //public GameObject backGround;



    //private void Start()
    //{
    //    // 메인 카메라와 캔버스 크기를 동기화 합니다.
    //    camera.orthographicSize = canvas.GetComponent<RectTransform>().sizeDelta.y / 2;

    //    // 백그라운드 이미지와 캔버스 크기를 동기화 합니다.
    //    backGround.GetComponent<RectTransform>().sizeDelta = new Vector2();
    //}

    public Camera camera;
    public RectTransform rectTransform;
    public Canvas canvas;

    private void Start()
    {
        // 캔버스의 크기를 가져옵니다.
        float canvasWidth = canvas.GetComponent<RectTransform>().sizeDelta.x / 2;
        float canvasHeight = canvas.GetComponent<RectTransform>().sizeDelta.y / 2;

        // 케마리의 크기를 캔버스와 일치시킵니다.
        camera.orthographicSize = canvasHeight / 2;

        // 배경의 크기를 캔버스와 일치시킵니다.
        rectTransform.sizeDelta = new Vector2(canvasWidth, canvasHeight);
    }

    #endregion
}
