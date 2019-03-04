using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    public Slider slider;
    float setVolume = 1.0f;

    void Start()
    {
        slider.value = setVolume;
    }
    void Update ()
    {
        AudioListener.volume = setVolume;
        setVolume = slider.value;
        //made changes for git
    }
    
}
