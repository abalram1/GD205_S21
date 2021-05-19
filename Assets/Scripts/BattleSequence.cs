using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;

public class BattleSequence : MonoBehaviour
{
    public float TimeLeft;
    [SerializeField] private UnityEvent TimeLimitReached; //makes this a private event
    public GameObject Pattern_Part; //made this a prefab;
    public GameObject[] DropPoints; //places the DDR elements to match using an array
    string Segment;
    public float DropSpeedMin;
    public float DropSpeedMax;

    public TextMeshProUGUI Timer;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void NewBattle()
    {
        Segment = GetSequence();
        StartCoroutine(DropParts());
    }                                
    // Update is called once per frame
    void Update()
    {
        TimeLeft -= Time.deltaTime;
        Timer.text = TimeLeft.ToString();
        if (TimeLeft <= 1)
        {
            TimeLeft = 30;
            ExitCondition();
        }
    }

    public void ExitCondition()
    {
        TimeLimitReached.Invoke();
    }

    public IEnumerator DropParts()
    {
        for (int x = 0; x < Segment.Length; x++)
        {

            string Dir = Segment.Substring(x, 1);

            Vector3 Position = Vector3.zero;
            if (Dir.Equals("L")) Instantiate(Pattern_Part, DropPoints[0].transform.position, Quaternion.identity); //removes the block when the key is pressed

            if (Dir.Equals("R")) Instantiate(Pattern_Part, DropPoints[1].transform.position, Quaternion.identity); //removes the block when the key is pressed

            if (Dir.Equals("U")) Instantiate(Pattern_Part, DropPoints[2].transform.position, Quaternion.identity); //removes the block when the key is pressed

            if (Dir.Equals("D")) Instantiate(Pattern_Part, DropPoints[3].transform.position, Quaternion.identity); //removes the block when the key is pressed

            yield return new WaitForSecondsRealtime(Random.Range(DropSpeedMin, DropSpeedMax));
        }
    }
    public string GetSequence()
    {
        string Pattern = "";
        for(int x = 200; x > 0; x--)
        {
            int y = Random.Range(1, 5);
            if (y == 1) Pattern += "U";
            else if (y == 2) Pattern += "D";
            else if (y == 3) Pattern += "L";
            else Pattern += "R";
        }
        return Pattern;
    }
}

