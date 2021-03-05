using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleMovement : MonoBehaviour
{
    public Vector3 fwd, bwd, lft, rgt, up, dwn;

    public Transform[] hazard; 
    
    public Transform key, door, FirstGameBoard, SecondGameBoard, ThirdGameBoard, FourthGameBoard, FifthGameBoard, SixthGameBoard;

    Vector3 startPos1, startPos2, startPos3, startPos4, startPos5, startPos6;

    Vector3 randomPos1, randomPos2, randomPos3, randomPos4, randomPos5, randomPos6;

    Vector3 randomDoorPos1, randomDoorPos2, randomDoorPos3, randomDoorPos4, randomDoorPos5, randomDoorPos6;

    Vector3 KeyPos1, KeyPos2, KeyPos3, KeyPos4, KeyPos5, KeyPos6;

    Vector3 hazardPos1, hazardPos2, hazardPos3, hazardPos4, hazardPos5, hazardPos6;

    Vector3 doorPos1, doorPos2, doorPos3, doorPos4, doorPos5, doorPos6;

    float randomhazardX1, randomhazardX2, randomhazardX3, randomhazardX4, randomhazardX5, randomhazardX6, randomhazardY1, randomhazardY2, randomhazardY3, randomhazardY4, randomhazardY5, randomhazardY6, randomhazardZ1, randomhazardZ2, randomhazardZ3, randomhazardZ4, randomhazardZ5, randomhazardZ6;

    float randomplayerX1, randomplayerX2, randomplayerX3, randomplayerX4, randomplayerX5, randomplayerX6, randomplayerY1, randomplayerY2, randomplayerY3, randomplayerY4, randomplayerY5, randomplayerY6, randomplayerZ1, randomplayerZ2, randomplayerZ3, randomplayerZ4, randomplayerZ5, randomplayerZ6;

    float randomDoorX1, randomDoorX2, randomDoorX3, randomDoorX4, randomDoorX5, randomDoorX6, randomDoorY1, randomDoorY2, randomDoorY3, randomDoorY4, randomDoorY5, randomDoorY6, randomDoorZ1, randomDoorZ2, randomDoorZ3, randomDoorZ4, randomDoorZ5, randomDoorZ6;

    float randomKeyX1, randomKeyX2, randomKeyX3, randomKeyX4, randomKeyX5, randomKeyX6, randomKeyY1, randomKeyY2, randomKeyY3, randomKeyY4, randomKeyY5, randomKeyY6, randomKeyZ1, randomKeyZ2, randomKeyZ3, randomKeyZ4, randomKeyZ5, randomKeyZ6;

    public bool hasKey;

    public AudioSource speaker, capsule;

    public AudioClip hazardClip, SmoothCriminal;

    void Start()
    {
        randomplayerX1 = Random.Range(-10, 10);
        randomplayerY1 = Random.Range(-10, 10);
        randomplayerZ1 = Random.Range(-10, 10);
        randomPos1 = new Vector3(randomplayerX1, randomplayerY1, randomplayerZ1);
        startPos1 = randomPos1;

        randomplayerX2 = Random.Range(-10, 10);
        randomplayerY2 = Random.Range(-10, 10);
        randomplayerZ2 = Random.Range(-10, 10);
        randomPos2 = new Vector3(randomplayerX2, randomplayerY2, randomplayerZ2);
        startPos2 = randomPos2;

        randomplayerX3 = Random.Range(-10, 10);
        randomplayerY3 = Random.Range(-10, 10);
        randomplayerZ3 = Random.Range(-10, 10);
        randomPos3 = new Vector3(randomplayerX3, randomplayerY3, randomplayerZ3);
        startPos3 = randomPos3;

        randomplayerX4 = Random.Range(-10, 10);
        randomplayerY4 = Random.Range(-10, 10);
        randomplayerZ4 = Random.Range(-10, 10);
        randomPos4 = new Vector3(randomplayerX4, randomplayerY4, randomplayerZ4);
        startPos4 = randomPos4;

        randomplayerX5 = Random.Range(-10, 10);
        randomplayerY5 = Random.Range(-10, 10);
        randomplayerZ5 = Random.Range(-10, 10);
        randomPos4 = new Vector3(randomplayerX4, randomplayerY4, randomplayerZ4);
        startPos4 = randomPos4;

        randomplayerX5 = Random.Range(-10, 10);
        randomplayerY5 = Random.Range(-10, 10);
        randomplayerZ5 = Random.Range(-10, 10);
        randomPos5 = new Vector3(randomplayerX5, randomplayerY5, randomplayerZ5);
        startPos5 = randomPos5;

        randomplayerX6 = Random.Range(-10, 10);
        randomplayerY6 = Random.Range(-10, 10);
        randomplayerZ6 = Random.Range(-10, 10);
        randomPos6 = new Vector3(randomplayerX6, randomplayerY6, randomplayerZ6);
        startPos6 = randomPos6;

        randomDoorX1 = Random.Range(-10, 10);
        randomDoorY1 = Random.Range(-10, 10);
        randomDoorZ1 = Random.Range(-10, 10);
        randomDoorPos1 = new Vector3(randomDoorX1, randomDoorY1, randomDoorZ1);

        randomDoorX2 = Random.Range(-10, 10);
        randomDoorY2 = Random.Range(-10, 10);
        randomDoorZ2 = Random.Range(-10, 10);
        randomDoorPos2 = new Vector3(randomDoorX2, randomDoorY2, randomDoorZ2);

        randomDoorX3 = Random.Range(-10, 10);
        randomDoorY3 = Random.Range(-10, 10);
        randomDoorZ3 = Random.Range(-10, 10);
        randomDoorPos3 = new Vector3(randomDoorX3, randomDoorY3, randomDoorZ3);

        randomDoorX4 = Random.Range(-10, 10);
        randomDoorY4 = Random.Range(-10, 10);
        randomDoorZ4 = Random.Range(-10, 10);
        randomDoorPos4 = new Vector3(randomDoorX4, randomDoorY4, randomDoorZ4);

        randomDoorX5 = Random.Range(-10, 10);
        randomDoorY5 = Random.Range(-10, 10);
        randomDoorZ5 = Random.Range(-10, 10);
        randomDoorPos5 = new Vector3(randomDoorX5, randomDoorY5, randomDoorZ5);

        randomDoorX6 = Random.Range(-10, 10);
        randomDoorY6 = Random.Range(-10, 10);
        randomDoorZ6 = Random.Range(-10, 10);
        randomDoorPos6 = new Vector3(randomDoorX6, randomDoorY6, randomDoorZ6);

        //door.position = randomDoorPos;
        doorPos1 = randomDoorPos1;
        doorPos2 = randomDoorPos2;
        doorPos3 = randomDoorPos3;
        doorPos4 = randomDoorPos4;
        doorPos5 = randomDoorPos5;
        doorPos6 = randomDoorPos6;

        randomKeyX1 = Random.Range(-10, 10);
        randomKeyY1 = Random.Range(-10, 10);
        randomKeyZ1 = Random.Range(-10, 10);
        KeyPos1 = new Vector3(randomKeyX1, randomKeyY1, randomKeyZ1);

        randomKeyX2 = Random.Range(-10, 10);
        randomKeyY2 = Random.Range(-10, 10);
        randomKeyZ2 = Random.Range(-10, 10);
        KeyPos2 = new Vector3(randomKeyX2, randomKeyY2, randomKeyZ2);

        randomKeyX3 = Random.Range(-10, 10);
        randomKeyY3 = Random.Range(-10, 10);
        randomKeyZ3 = Random.Range(-10, 10);
        KeyPos3 = new Vector3(randomKeyX3, randomKeyY3, randomKeyZ3);

        randomKeyX4 = Random.Range(-10, 10);
        randomKeyY4 = Random.Range(-10, 10);
        randomKeyZ4 = Random.Range(-10, 10);
        KeyPos4 = new Vector3(randomKeyX4, randomKeyY4, randomKeyZ4);

        randomKeyX5 = Random.Range(-10, 10);
        randomKeyY5 = Random.Range(-10, 10);
        randomKeyZ5 = Random.Range(-10, 10);
        KeyPos5 = new Vector3(randomKeyX5, randomKeyY5, randomKeyZ5);

        randomKeyX6 = Random.Range(-10, 10);
        randomKeyY6 = Random.Range(-10, 10);
        randomKeyZ6 = Random.Range(-10, 10);
        KeyPos6 = new Vector3(randomKeyX6, randomKeyY6, randomKeyZ6);

        //key.position = randomKeyPos;

        randomhazardX1 = Random.Range(-10, 10);
        randomhazardY1 = Random.Range(-10, 10);
        randomhazardZ1 = Random.Range(-10, 10);
        hazardPos1 = new Vector3(randomhazardX1, randomhazardY1, randomhazardZ1);

        randomhazardX2 = Random.Range(-10, 10);
        randomhazardY2 = Random.Range(-10, 10);
        randomhazardZ2 = Random.Range(-10, 10);
        hazardPos2 = new Vector3(randomhazardX2, randomhazardY2, randomhazardZ2);

        randomhazardX3 = Random.Range(-10, 10);
        randomhazardY3 = Random.Range(-10, 10);
        randomhazardZ3 = Random.Range(-10, 10);
        hazardPos3 = new Vector3(randomhazardX3, randomhazardY3, randomhazardZ3);

        randomhazardX4 = Random.Range(-10, 10);
        randomhazardY4 = Random.Range(-10, 10);
        randomhazardZ4 = Random.Range(-10, 10);
        hazardPos4 = new Vector3(randomhazardX4, randomhazardY4, randomhazardZ4);

        randomhazardX5 = Random.Range(-10, 10);
        randomhazardY5 = Random.Range(-10, 10);
        randomhazardZ5 = Random.Range(-10, 10);
        hazardPos5 = new Vector3(randomhazardX5, randomhazardY5, randomhazardZ5);

        randomhazardX6 = Random.Range(-10, 10);
        randomhazardY6 = Random.Range(-10, 10);
        randomhazardZ6 = Random.Range(-10, 10);
        hazardPos6 = new Vector3(randomhazardX6, randomhazardY6, randomhazardZ6);

        hasKey = false;

    }


    void Update()
    {
        capsule.PlayOneShot(SmoothCriminal, .5f);

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


        for(int i = 0; i < hazard.Length; i++)
        {
            if(hazard[i].position == transform.position)
            {   transform.position = startPos1;
                speaker.PlayOneShot(hazardClip, .9f);
            }
        }
        //if (hazardPos1 == transform.position)
        //{
        //   Debug.Log("That was terrible!");
        //    transform.position = startPos1;
        //    speaker.PlayOneShot(hazardClip, .9f);
        //}

        //if (hazardPos2 == transform.position)
        //{
        //    Debug.Log("Reset");
        //    transform.position = startPos2;
        //   speaker.PlayOneShot(hazardClip, .9f);
        //}

        //if (hazardPos3 == transform.position)
        //{
        //    Debug.Log("Nice try");
        //    transform.position = startPos3;
        //    speaker.PlayOneShot(hazardClip, .9f);
        //}

        //if (hazardPos4 == transform.position)
        //{
        //    Debug.Log("Can you make it?");
        //    transform.position = startPos4;
        //    speaker.PlayOneShot(hazardClip, .9f);
        //}

        //if (hazardPos5 == transform.position)
        //{
        //    Debug.Log("Almost");
        //    transform.position = startPos5;
        //    speaker.PlayOneShot(hazardClip, .9f);
        //}

        //if (hazardPos6 == transform.position)
        //{
        //    Debug.Log("So close!");
        //    transform.position = startPos6;
        //    speaker.PlayOneShot(hazardClip, .9f);
        //}

        if (KeyPos1 == transform.position)
        {
            hasKey = true;
            key.gameObject.SetActive(false);
        }

        if (KeyPos2 == transform.position)
        {
            hasKey = true;
            key.gameObject.SetActive(false);
        }

        if (KeyPos3 == transform.position)
        {
            hasKey = true;
            key.gameObject.SetActive(false);
        }

        if (KeyPos4 == transform.position)
        {
            hasKey = true;
            key.gameObject.SetActive(false);
        }

        if (KeyPos5 == transform.position)
        {
            hasKey = true;
            key.gameObject.SetActive(false);
        }

        if (KeyPos6 == transform.position)
        {
            hasKey = true;
            key.gameObject.SetActive(false);
        }


        if (doorPos1 == transform.position && hasKey)
        {
            SecondGameBoard.gameObject.SetActive(true);
            door.gameObject.SetActive(false);
            FirstGameBoard.gameObject.SetActive(false);
            startPos1 = randomPos1;
        }

        if (doorPos2 == transform.position && hasKey)
        {
            ThirdGameBoard.gameObject.SetActive(true);
            door.gameObject.SetActive(false);
            SecondGameBoard.gameObject.SetActive(false);
            startPos2 = randomPos2;
        }

        if (doorPos3 == transform.position && hasKey)
        {
            FourthGameBoard.gameObject.SetActive(true);
            door.gameObject.SetActive(false);
            ThirdGameBoard.gameObject.SetActive(false);
            startPos3 = randomPos3;
        }

        if (doorPos4 == transform.position && hasKey)
        {
            FifthGameBoard.gameObject.SetActive(true);
            door.gameObject.SetActive(false);
            FourthGameBoard.gameObject.SetActive(false);
            startPos4 = randomPos4;
        }

        if (doorPos5 == transform.position && hasKey)
        {
            SixthGameBoard.gameObject.SetActive(true);
            door.gameObject.SetActive(false);
            FifthGameBoard.gameObject.SetActive(false);
            startPos5 = randomPos5;
        }

        if (doorPos6 == transform.position && hasKey)
        {
            Debug.Log("You win! Congrats!");
        }
    }
}
