//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //This is in reference to the rigidbody component "rb"
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // We are calling this "Fixed" Update because we are using it to mess with physics
    void FixedUpdate()
    {
        //add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); 

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -2f){
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
