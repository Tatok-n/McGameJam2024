using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeCopy : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider2 = null;

    [SerializeField] private Text volumeTextUI2 = null;
    
    private void Start()
    {
        LoadValues();
    }

    public void VolumeSlider(float volume2)
    {
        volumeTextUI2.text = volume2.ToString("0.0");
    }

    public void SaveVolumeButton()
    {
        float volumeValue2 = volumeSlider2.value;
        PlayerPrefs.SetFloat("VolumeValue", volumeValue2);
        LoadValues();
    }

    void LoadValues()
    {
        float volumeValue2 = PlayerPrefs.GetFloat("VolumeValue");
        volumeSlider2.value = volumeValue2;
        AudioListener.volume = volumeValue2;
    }
}
