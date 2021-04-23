using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIStuff : MonoBehaviour
{
    public Text healthUI, timer;
    public int healthCount;
    public float timerAmount;

    void Start()
    {
        //healthUI = GetComponent<Text>();
        healthCount = 100;
    }


    void Update()
    {
        healthUI.text = "Health" + healthCount;
        timer.text =  "Time" + (timerAmount - (int)Time.timeSinceLevelLoad);
        if (Time.timeSinceLevelLoad > timerAmount)
        {
            ReloadScene();
        }
    }

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("Trigger entered");
        if (col.CompareTag("Heal"))
        {
            healthCount++;
            Destroy(col.gameObject);
        }
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }


    public void QuitGame()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            Application.Quit(); 
        }
    }

}