using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    public AudioMixer audioMixer;
    public AudioSource bgmSource;
    public AudioSource sfxSource;


    [SerializeField] Slider bgmVolumeSlider;
    [SerializeField] Slider sfxVolumeSlider;

    private void Start()
    {
        bgmVolumeSlider.value = 0.5f;
        sfxVolumeSlider.value = 0.5f;
    }

    public void SetBgmVolume(float vol)
    {
        audioMixer.SetFloat("MyBGMpara", Mathf.Log10(vol)*20);
    }

    public void SetSfxVolume(float vol)
    {
        audioMixer.SetFloat("MySFXpara", Mathf.Log10(vol) * 20);
    }

    public void SFXPlay(string sfxName, AudioClip clip)
    {
        GameObject go = new GameObject(sfxName + "Sound");
        AudioSource audioSource = go.AddComponent<AudioSource>();
        audioSource.clip = clip;
        audioSource.Play();

        Destroy(go, clip.length);
    }

    public void BGMPlay(AudioClip clip)
    {
        bgmSource.clip = clip;
        bgmSource.loop = true;
        bgmSource.volume = 0.4f;
        bgmSource.Play();
    }
}
