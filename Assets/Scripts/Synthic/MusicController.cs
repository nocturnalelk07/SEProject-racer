using Synthic;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private double modulatorSpeed = 0.1;
    [SerializeField] private double modulatorDepth = 0.2;
    [SerializeField] private bool volume;
    [SerializeField] private bool pitch;
    [SerializeField] private AnimationCurve graph;

    private float graphTime = 0;
    [SerializeField] float maxGraphTime = 1.5f;
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
        audioSource.volume = graph.Evaluate(graphTime);
        graphTime += Time.fixedDeltaTime;
        if (graphTime >= maxGraphTime) 
        {
            graphTime = 0;
        }
        LFO_index = LFO_index + (float)modulatorSpeed;
        if (volume) 
        {
            audioSource.volume = (float)((Mathf.Sin(LFO_index) * modulatorDepth));
        }
        if (pitch)
        {
            //audioSource.pitch = (float)((Mathf.Sin(LFO_index) * modulatorDepth));
            audioSource.pitch = Mathf.Abs((float)(LFOSawtoothWave(LFO_index)));
        }
        
    }

    private double LFOSawtoothWave(float input)
    {
        return (2 * (input - math.floor(input)));
    }
}
