using Synthic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private SquareWaveGenerator wave;


    //this will set the volume of the wave being played
    //not properly implemented currently
    public void setVolume(double volume)
    {
        audioSource.volume = (float) volume;
        Debug.Log(volume);
    }
}
