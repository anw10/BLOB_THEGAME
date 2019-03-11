using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    public Slider slider;

    void Start()
    {
        if (PlayerPrefs.HasKey("volume"))
        {
            slider.value = PlayerPrefs.GetFloat("volume");
            AudioListener.volume = PlayerPrefs.GetFloat("volume");
        }
        else
        {
            slider.value = 1.0f;
            AudioListener.volume = 1.0f;
        }

    }
    void Update()
    {
        PlayerPrefs.SetFloat("volume", slider.value);
        AudioListener.volume = PlayerPrefs.GetFloat("volume");
    }

}