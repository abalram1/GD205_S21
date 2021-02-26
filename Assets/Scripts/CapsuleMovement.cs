using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleMovement : MonoBehaviour
{
    public Vector3 fwd, bwd, lft, rgt, up, dwn;
    public Transform hazard, key, door, newRoom, oldRoom;
    Vector3 startPos;
    public bool hasKey;
    public AudioSource speaker;
    public AudioClip hazardClip;

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
            transform.position += fwd;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("You pressed s");
            transform.position += bwd;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("You pressed d");
            transform.position += rgt;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("You pressed a");
            transform.position += lft;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("You pressed e");
            transform.position += up;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("You pressed q");
            transform.position += dwn;
        }

        if (hazard.position == transform.position)
        {
            transform.position = startPos;
            speaker.PlayOneShot(hazardClip, .9f);
        }
       
        if (key.position == transform.position)
        {
            hasKey = true;
            key.gameObject.SetActive(false);
        }

        if (door.position == transform.position && hasKey)
        {
            newRoom.gameObject.SetActive(true);
            door.gameObject.SetActive(false);
            oldRoom.gameObject.SetActive(false);
            startPos = transform.position;
        }

     
    }

}
