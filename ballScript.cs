using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //added scenes

public class ballScript : MonoBehaviour
{
    //importing necessary parameters that would be accessed in future
    public Rigidbody2D rb;
    public float ballForce;
    public int collisionScore;
    public AudioSource brickBreakingSound; //Special variable for audio

    //setting up the collisionScore, which is a number of red bricks by default, as starting conditions
    //making audio play each time the ball hits any kind of brick
    private void Start()
    {
        {
            collisionScore = 14;
            brickBreakingSound = GetComponent<AudioSource>();
        }
    }

    //the ball has a counter, and when the counter goes to "0", the sceneM loads new scene.
    void Update()
    {
        if (Input.GetKey(KeyCode.N) == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (collisionScore == 0 && SceneManager.GetActiveScene().name == "Level3")
        {
            SceneManager.LoadScene("FinalWinMenu");
        }

        if (collisionScore == 0)
        {
            CompleteStop();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        }

        //adding force to a ball when pressing space
        if (Input.GetKeyUp(KeyCode.Space)) 
        {
            transform.SetParent(null);
            rb.isKinematic = false;
            rb.AddForce(new Vector2(ballForce, ballForce));
        } 
    }

    //separate function for just stopping the ball
    public void CompleteStop()
    {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = 0f;
    }

    //playing sounds if hitting a brick
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "brick")
        {
            brickBreakingSound.Play();
        }

    }

}
