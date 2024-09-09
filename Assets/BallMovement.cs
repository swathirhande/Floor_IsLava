using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 2.0f;
    private bool move = true;
    private Rigidbody rb;

    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (move)
        {
            // Automatically move the ball forward on the X axis
            rb.velocity = new Vector3(speed, rb.velocity.y, rb.velocity.z);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "StopPoint")
        {
            
            move = false;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;  
            rb.isKinematic = true;
        }
    }
}

