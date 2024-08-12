using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class RaceTracker : MonoBehaviour
{
    [SerializeField]
    private BoxCollider startLine;

    [SerializeField]
    private TMP_Text timer;

    [SerializeField]
    private TMP_Text speedometer;

    [SerializeField]
    CarControl carScript;

    private bool started = false;
    private float timePassed;

    public void startRace()
    {
        if (!started)
        {
            started = true;
            timePassed = 0;
        }
    }
   
    public void stopRace()
    {
        started = false; 
    }

    private void addTime()
    {
        timePassed = timePassed + Time.deltaTime;
    }

    private string formatTimePassed()
    {
        TimeSpan time = TimeSpan.FromSeconds(timePassed);
        return time.ToString("hh':'mm':'ss");
    }

    void Update()
    {
        string carSpeed = carScript.getCarSpeed().ToString();
        speedometer.text = (carSpeed + " MPH");
    }

    void FixedUpdate()
    {
        if (started)
        {
            addTime();
            timer.text = formatTimePassed();
        }
    }

    public bool getStarted()
    {
        return started;
    }

    public float getTimePassed()
    {
        return timePassed;
    }
}
