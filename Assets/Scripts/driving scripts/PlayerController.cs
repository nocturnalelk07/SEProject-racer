using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerController : MonoBehaviour
{

    private PlayerDrivingControls playerControls;
    private Vector2 accelerateVector;
    private Vector2 turningVector;
    private double acceleration;
    private double turn;
    //reference to the carbehaviour of the players car
    public CarBehaviour car;
    
    //car reference for car the player is driving

    private void Awake()
    {
        playerControls = new PlayerDrivingControls();
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }
   
    void Start()
    {
        
    }

    private void Update()
    {
        
        //Debug.Log(turn);
        //Debug.Log(acceleration);
        //Debug.Log(accelerateVector);
        //Debug.Log(turn);
        
    }

    private void FixedUpdate()
    {
        accelerateVector = playerControls.Driving.AccelerateDecelerate.ReadValue<Vector2>();
        acceleration = accelerateVector[1] * car.getAcceleration();
        turningVector = playerControls.Driving.Turn.ReadValue<Vector2>();
        turn = turningVector[0];
        car.addVelocity((float)acceleration);
        //Debug.Log(car.getVelocity());

        car.turn((float)turn);
        Debug.Log(car.getTurningSpeed());
    }
}
