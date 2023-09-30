using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShpMovement2d : MonoBehaviour
{
    public GameObject target;
    public float velocity;
    public float horizontal;
    public float vertical;
    public float thrustForce;
    public float rotationSpeed;
    public float acceleration = 30;

    void Update()
    {

        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        transform.position += transform.forward * thrustForce * vertical * Time.deltaTime;
        transform.Rotate(Vector3.up, horizontal * Time.deltaTime * rotationSpeed);

    }

}

