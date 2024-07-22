using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;

//outlines the behaviour of a car object, this has been kept as generic as possible to work for player and non player cars
public class CarBehaviour : MonoBehaviour
{
    //this is the speed of the car forwards (positive) or in reverse (negative)
    private float velocity = 0;
    //the turning rate of the car
    private float turningTorque = 5;
    //how much the car is currently turning
    private float turningSpeed = 0;
    //the acceleration of the car
    private float acceleration = 5;
    //is the engine on?
    private bool engineOn = false;
    //the reference to the car rigidbody
    public Rigidbody rb;


    void Start()
    {

    }

    void Update()
    {
       
    }

    private void FixedUpdate()
    {
        Vector3 force = new Vector3(turningSpeed, 0, velocity);
        rb.AddForce(force);
        Debug.Log(force);
    }

    public void turn(float turnAmount)
    {
        turningSpeed = turnAmount * turningTorque;
    }

    public void addVelocity(float deltaVelocity)
    {
        velocity += deltaVelocity;
    }

    public void setVelocity(float velocity)
    {
        this.velocity = velocity;
    }
    public float getVelocity()
    {
        return velocity;
    }

    public float getAcceleration()
    {
        return acceleration;
    }

    public float getTurningTorque() 
    { 
        return turningTorque;
    }

    public float getTurningSpeed()
    {
        return turningSpeed;
    }
}
