using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SoundController : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider sfxSlider;
    public Slider musicSlider;

    float sfxVolume;
    float musicVolume;

    public void AudioControl()
    {
        if (sfxVolume == -40f) audioMixer.SetFloat("SFX", -80);
        else audioMixer.SetFloat("SFX", sfxVolume);

        if (musicVolume == -40f) audioMixer.SetFloat("Music", -80);
        else audioMixer.SetFloat("Music", musicVolume);

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        sfxVolume = sfxSlider.value;
        musicVolume = musicSlider.value;
    }
}
