using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaucerThrust : MonoBehaviour
{
    Rigidbody rb;
    public float thrustAmt = 2f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    
    void Update()
    {
      if (Input.GetKey(KeyCode.W)) //move foward
        {
            rb.AddForce(new Vector3(0f, 0f, 1f) * thrustAmt);
        }

      if (Input.GetKey(KeyCode.S)) //move backward
        {
            rb.AddForce(new Vector3(0f, 0f, -1f) * thrustAmt);
        }

      if (Input.GetKey(KeyCode.Q)) //move up
        {
            rb.AddForce(new Vector3(0f, 1f, 0f) * thrustAmt);
        }

      if (Input.GetKey(KeyCode.E)) //move down
        {
            rb.AddForce(new Vector3(0f, 1f, 0f) * thrustAmt);
        }
      
      if (Input.GetKey(KeyCode.D)) //move right
        {
            rb.AddForce(new Vector3(1f, 0f, 0f) * thrustAmt);
        }

      if (Input.GetKey(KeyCode.A)) //move left
        {
            rb.AddForce(new Vector3(0f, 0f, -1f) * thrustAmt);
        }

      if (Input.GetKey(KeyCode.Space)) //brake
        {
            rb.velocity *= 0.5f;
        }

    }

    void OnCollisionEnter(Collision collisionReport)
    {
        Debug.Log("SNAKE!!!!!!!!!!!!!!!!!!!!! You hit " + collisionReport.gameObject.name);
        GetComponent<ParticleSystem>().Play();
    }
}
