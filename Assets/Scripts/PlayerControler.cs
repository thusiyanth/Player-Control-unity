using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{   
    //defining game speed 
    private float speed = 10.0f;
    //turning speed
    private float turnSpeed=24.0f;
    //geting input varaiable
    private float horizontalInput;
    //forwed speed
    private float forwardInput;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //Smooth the Camera with LateUpdate
    void LateUpdate()
    {

        // Move the vehicle  horizontal
        horizontalInput = Input.GetAxis("Horizontal");

        //move forwaed 
        forwardInput = Input.GetAxis("Vertical");

        /*
         Vector3=> x,y,x  aixs denoted
        forward  => moving straite x axis
         */
        transform.Translate(Vector3.forward * Time.deltaTime*speed* forwardInput);
        //turing right side
        // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed*horizontalInput);
        //rotae UP means turing side 
        //if(hor)
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        
       

    }
}
