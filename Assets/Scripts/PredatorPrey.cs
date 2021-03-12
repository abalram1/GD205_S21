using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PredatorPrey : MonoBehaviour
{

    Rigidbody myRB;
    public Transform target;
    public float thrustAmt = 3f;
    public float awarenessThresh = 5f;

    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(target.position, transform.position) < awarenessThresh)
        {
            myRB.AddForce(Vector3.Normalize(target.position - transform.position) * thrustAmt);
        }
       // if (Input.GetKeyDown(KeyCode.F))
        //{
        //    thrustAmt *= -1f;
        }
    }

