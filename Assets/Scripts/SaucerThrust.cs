using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaucerThrust : MonoBehaviour
{
    Rigidbody rb;
    public float thrustAmt = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    
    void Update()
    {
      if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(new Vector3(0f, 0f, 1f) * thrustAmt);
        }

      if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(new Vector3(0f, 0f, -1f) * thrustAmt);
        }

      if (Input.GetKey(KeyCode.Space))
        {
            rb.Velocity *= 0.95f;
        }

    }
}
