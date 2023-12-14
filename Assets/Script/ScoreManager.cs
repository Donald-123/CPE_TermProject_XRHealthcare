using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager instance; //static variable of the class to allow update in the value of the score

    public Text scoreText;//Receiving the textobject to update the text

    int score = 0;

    private void Awake() //initialize the static variable to the class itself
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = "POINTS: " + score.ToString();  //display the update of the score in the text
    }
    
    public void ScoreUp()
    {
        score += 1;//increment the score by one
        scoreText.text = score.ToString() + " POINTS"; //formatting the score to be displayed on the board
    }
}
