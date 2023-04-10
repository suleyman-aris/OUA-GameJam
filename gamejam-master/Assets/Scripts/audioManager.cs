using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class audioManager : MonoBehaviour
{
    public Slider slider;
    private void Start()
    {
        loadAudio();
    }
    public void setAudio(float value)
    {
        AudioListener.volume = value;
        saveAudio();
    }
    private void saveAudio()
    {
        PlayerPrefs.SetFloat("audioVolume", AudioListener.volume);

    }
    private void loadAudio()
    {
        if (PlayerPrefs.HasKey("audioVolume"))
        {
            AudioListener.volume = PlayerPrefs.GetFloat("audioVolume");
            slider.value = PlayerPrefs.GetFloat("audioVolume");
        }
        else
        {
            PlayerPrefs.SetFloat("audioVolume", 0.3f);
            AudioListener.volume = PlayerPrefs.GetFloat("audioVolume");
            slider.value = PlayerPrefs.GetFloat("audioVolume");
        }
    }
}
