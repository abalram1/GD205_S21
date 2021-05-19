using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DropScanner : MonoBehaviour
{
    public Scan L; 
    public Scan R;
    public Scan U;
    public Scan D;


    public int Score;
    public TextMeshProUGUI ScoreText;
    public int ScoreLimit = 50;
    public GameObject BattleSequenceMaster;
    public GameObject Win;

    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Score >= ScoreLimit)//win condition
        {
            Win.SetActive(true);
            BattleSequenceMaster.GetComponent<BattleSequence>().ExitCondition();    
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && L.Closed)//when the player presses left arrow as a match
        {
            Score++;
            L.Activated();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && R.Closed)//when the player presses right arrow as a match
        {
            Score++;
            R.Activated();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && D.Closed)//when the player presses down arrow as a match
        {
            Score++;
            D.Activated();
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && U.Closed)//when the player presses up arrow as a match
        {
            Score++;
            U.Activated();
        }
        ScoreText.text = Score.ToString(); //sets the numeral score to a text
    }

}
