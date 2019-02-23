using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManagerScript : MonoBehaviour
{

    public int score = 0;
    public Text scoreText;

    //setting up a function to increment score for score UI element
    public void IncrementScore()
     {
        score++;
        scoreText.text = "Score: " + score;
    }

    //a function to print out 'you lost' if the ball hits the lower quad
    public void LostGame()
    {
        scoreText.text = "You lost!";
    }
}
