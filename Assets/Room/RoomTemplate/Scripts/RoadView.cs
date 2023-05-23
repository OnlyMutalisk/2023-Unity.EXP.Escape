using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoadView : MonoBehaviour
{
    public string nextRoomName;

    /// <summary>
    /// 다음 방으로 이동시킵니다.
    /// </summary>
    public void Move()
    {
        SceneManager.LoadScene(nextRoomName);
    }
}
