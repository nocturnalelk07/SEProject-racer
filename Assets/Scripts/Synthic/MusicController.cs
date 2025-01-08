using Synthic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private SynthProvider wave;

    private float LFO_index;
    private double modulatorSpeed = 0.1;
    private double modulatorDepth = 0.2;

    //this will set the volume of the wave being played
    //not properly implemented currently
    public void setVolume(double volume)
    {
        audioSource.volume = (float) volume;

    }

    private void FixedUpdate()
    {
        //double _phase = wave.getPhase();
        //setVolume(_phase);
        
        LFO_index = LFO_index + (float) modulatorSpeed;
        audioSource.volume = (float)((Mathf.Sin(LFO_index) * modulatorDepth));

    }
}
