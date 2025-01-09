using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carMusicController : MonoBehaviour
{
    //this will use data from the player's car to change variables in the music controller

    [SerializeField] private MusicController musicController;
    [SerializeField] private CarControl car;

    private void FixedUpdate()
    {
        //get the speed of the car and normalise it
        float speed = car.getCarSpeed();
        float minimumSpeed = 0;
        float maximumSpeed = car.getCarMaximumSpeed();
        float adjustedSpeed = ((speed - minimumSpeed) / (maximumSpeed - minimumSpeed)); //this could be simpler since minimum speed should always be 0
        musicController.setModulatorSpeed(adjustedSpeed);
    }
}
