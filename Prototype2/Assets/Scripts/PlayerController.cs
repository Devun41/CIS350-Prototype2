/*
 Devun Schneider
 Prototype 2
 Controls the movement of the player character
 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.4f;
    public float xRange = 14;

    // Update is called once per frame
    void Update()
    {
        //get horizontal input from A and D or Arrow keys
        horizontalInput = Input.GetAxis("Horizontal");

        //transform horizontally w input
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //keep player in bounds
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.y); 
        }

    }
}
