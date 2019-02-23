using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bottomQuadScript : MonoBehaviour
{
    //reference to Uimanager and ballScript to further use them later
    public UiManagerScript ui;
    public ballScript ball;


    //passing the parameters i'll use in future into start function so that they are already accessible
    void Start()
    {
        ui = GameObject.FindWithTag("ui").GetComponent<UiManagerScript>();
        ball = GameObject.FindWithTag("Ball").GetComponent<ballScript>();

    }

    //losing scheme - if ball touches the bottom quad, the player looses the game
    void OnCollisionEnter2D(Collision2D col)
    { 
    
        if (col.gameObject.tag == "Ball")
        {
            ball.CompleteStop();
            SceneManager.LoadScene("LostMenu");
        }
    }
    
    
}
