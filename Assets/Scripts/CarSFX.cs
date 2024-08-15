using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSFX : MonoBehaviour
{
    [SerializeField]
    private AudioSource acceleration;
    [SerializeField]
    private AudioSource braking;
    [SerializeField]
    private CarControl carControl;

    private void Awake()
    {
        acceleration.Play();
        braking.Play();
        acceleration.Pause();
        braking.Pause();
    }
    // make sounds louder based on speed
    void Update()
    {
        float vInput = Input.GetAxis("Vertical");
        float speedFactor = ((float) carControl.getCarSpeed() / (float) carControl.getCarMaximumSpeed());
        //Debug.Log(speedFactor);

        if (vInput > 0)
        {
            braking.Pause();
            acceleration.volume = speedFactor;
            acceleration.UnPause();
        } else if (vInput < 0)
        {
            acceleration.Pause();
            braking.volume = speedFactor;
            braking.UnPause();
        }
    }
}
