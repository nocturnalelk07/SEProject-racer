using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndRace : MonoBehaviour
{

    [SerializeField]
    private RaceTracker tracker;

    private void OnTriggerEnter(Collider other)
    {
        if (tracker.getStarted())
        {
            tracker.stopRace();
            Debug.Log("race started");
        }
    }
}
