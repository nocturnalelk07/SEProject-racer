using Synthic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private double modulatorSpeed = 0.1;
    [SerializeField] private double modulatorDepth = 0.2;

    private float LFO_index;

    //this will set the volume of the wave being played
    //not properly implemented currently
    public void setVolume(double volume)
    {
        audioSource.volume = (float) volume;

    }

    public void setModulatorSpeed(double speed)
    {
        modulatorSpeed = speed;
    }

    private void FixedUpdate()
    {
        //double _phase = wave.getPhase();
        //setVolume(_phase);
        
        LFO_index = LFO_index + (float) modulatorSpeed;
        audioSource.volume = (float)((Mathf.Sin(LFO_index) * modulatorDepth));

    }
}
