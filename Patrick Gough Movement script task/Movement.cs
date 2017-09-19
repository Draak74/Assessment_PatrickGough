using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public bool wPressed;
    public bool aPressed;
    public bool dPressed;
    public bool sPressed;
    public bool spacePressed;

    public float movementspeed;
    public float jumpheight;
	
	void Update () {
        wPressed = Input.GetKey(KeyCode.W);
        aPressed = Input.GetKey(KeyCode.A);
        dPressed = Input.GetKey(KeyCode.D);
        sPressed = Input.GetKey(KeyCode.S);
        spacePressed = Input.GetKeyDown(KeyCode.Space);
    }

    private void FixedUpdate()
    {
        if (wPressed == true)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.forward * movementspeed, ForceMode.VelocityChange);
        }
        if (aPressed == true)
        {
            GetComponent<Rigidbody>().AddForce(-Vector3.right * movementspeed, ForceMode.VelocityChange);
        }
        if (dPressed == true)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right * movementspeed, ForceMode.VelocityChange);
        }
        if (sPressed == true)
        {
            GetComponent<Rigidbody>().AddForce(-Vector3.forward * movementspeed, ForceMode.VelocityChange);
        }
        if (spacePressed == true)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpheight);
        }
    }
}

//Possible Improvements:
//Change public bools to private bools ie. change "public bool wPressed;" to "private bool wPressed;"
//This change can improve the script as the public bools are not needed to be seen in the Unity inspector.
//Another improvement that could be changed is, the removal of "== true" in the "if" statements, 
//This is because the script already knows that if for example the player presses the W key, 
//It already knows to move whatever the script has been applied to, to move it in that direction.
