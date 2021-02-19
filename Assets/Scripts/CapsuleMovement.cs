using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleMovement : MonoBehaviour
{
    public Vector3 fwd, bwd, lft, rgt, up, dwn;
    public Transform hazard, key;
    Vector3 startPos;
    public bool hasKey;


    void Start()
    {
        startPos = transform.position;
        hasKey = false;
    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("You pressed w");
            //transform.Translate(0, 0, Time.deltaTime, Camera.main.transform);
            transform.position += fwd;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("You pressed s");
            //transform.Translate(0, 0, -Time.deltaTime, Camera.main.transform);
            transform.position += bwd;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("You pressed d");
            //transform.Translate(Time.deltaTime, 0, 0, Camera.main.transform);
            transform.position += rgt;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("You pressed a");
            //transform.Translate(-Time.deltaTime, 0, 0, Camera.main.transform);
            transform.position += lft;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("You pressed e");
            //transform.Translate(0, Time.deltaTime, 0, Space.World);
            transform.position += up;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("You pressed q");
            //transform.Translate(0, -Time.deltaTime, 0, Space.World);
            transform.position += dwn;
        }

        if (hazard.position == transform.position)
        {
            transform.position = startPos;
        }

        if (key.position == transform.position)
        {
            hasKey = true;
        }

    }

}
