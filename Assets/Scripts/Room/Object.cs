using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Object : MonoBehaviour
{
    // 인스펙터에서 연결할 오디오소스 오브젝트 입니다.
    public AudioSource audioSource;

    // 오브젝트 클릭 시 기본 작동 코드 입니다.
    public void ClickObject()
    {
        audioSource.clip = Resources.Load<AudioClip>("Sounds/Object/" + gameObject.name);
        audioSource.Play();
    }
}
