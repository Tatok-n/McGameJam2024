using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VolumeSaveController : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider = null;

    [SerializeField] private TextMeshProUGUI volumeTextUI = null;
    

    public void VolumeSlider(float volume)
    {
        //volumeTextUI.TextMeshProUGUI = volume.ToString("0.0");
    }
}
