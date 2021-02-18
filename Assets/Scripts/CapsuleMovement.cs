using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleMovement : MonoBehaviour
{



    void Start()
    {

    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("You pressed w");
            transform.Translate(0, 0, Time.deltaTime, Camera.main.transform);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("You pressed s");
            transform.Translate(0, 0, -Time.deltaTime, Camera.main.transform);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("You pressed d");
            transform.Translate(Time.deltaTime, 0, 0, Camera.main.transform);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("You pressed a");
            transform.Translate(-Time.deltaTime, 0, 0, Camera.main.transform);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("You pressed q");
            transform.Translate(0, Time.deltaTime, 0, Space.World);
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("You pressed z");
            transform.Translate(0, -Time.deltaTime, 0, Space.World);
        }
    }
}
