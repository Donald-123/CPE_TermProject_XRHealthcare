using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Threading;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeValue = 90; //set value for the timer 
    public TMP_Text countdowntext; //Receiving the object of text



    private void Update()
    {   //As long as the timeValue is remaining, keep on decrementing the timevalue
        if (timeValue  > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0; //timer is over
        }
        displayTime(timeValue);
    }

    void displayTime(float DisplayTime)
    {
        if(DisplayTime < 0)
        {
            DisplayTime = 0; //Timer is over
            countdowntext.text = "GAMEOVER"; //display the gameover text
            SceneManager.LoadScene(0); //move back to the main menu
        }

        float minutes = Mathf.FloorToInt(DisplayTime / 60); //calculate the minute
        float seconds = Mathf.FloorToInt(DisplayTime % 60); //calculate the second

        countdowntext.text = string.Format("{0:00}:{1:00}", minutes, seconds); //formatting the time
    }
}
