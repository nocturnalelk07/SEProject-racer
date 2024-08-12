using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartEndRace : MonoBehaviour
{

    [SerializeField]
    private RaceTracker tracker;

    private void OnTriggerEnter(Collider other)
    {
        if (!tracker.getStarted())
        {
            tracker.startRace();
            Debug.Log("race started");
        } else
        {
            tracker.stopRace();
            Debug.Log("race finished!!");
        }
    }
}
