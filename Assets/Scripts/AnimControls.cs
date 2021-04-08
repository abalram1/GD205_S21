using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControls: MonoBehaviour
{

    Animator ninjadance, flipkick;
    // Start is called before the first frame update
    void Start()
    {
        ninjadance = GetComponent<Animator>();
        flipkick = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            ninjadance.SetInteger("Animation State", 1);
            flipkick.SetInteger("Animation State", 1);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            ninjadance.SetInteger("Animation State", 2);
            flipkick.SetInteger("Animation State", 2);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            ninjadance.SetInteger("Animation State", 3);
            flipkick.SetInteger("Animation State", 3);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            ninjadance.SetInteger("Animation State", 4);
            flipkick.SetInteger("Animation State", 4);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            ninjadance.SetInteger("Animation State", 0);
            flipkick.SetInteger("Animation State", 0);
        }

       }
    }
