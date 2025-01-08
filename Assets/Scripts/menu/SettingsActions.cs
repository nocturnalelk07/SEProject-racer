using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsActions : MonoBehaviour
{

    public void SetVolume(float newVolume)
    {
        PlayerPrefs.SetFloat("Volume", newVolume);
        AudioListener.volume = PlayerPrefs.GetFloat("Volume");
        //Debug.Log("volume set");
    }
}
