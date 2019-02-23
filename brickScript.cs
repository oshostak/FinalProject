using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brickScript : MonoBehaviour
{
    public ballScript ball;

    //importing ball's data
    void Start()
    {
        ball = GameObject.FindWithTag("Ball").GetComponent<ballScript>();
    }

    //collision function that uses unity collider and basically destroys the object and reduces the ball counter
    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ball")
        {
            ball.collisionScore--;
            Destroy(gameObject);
        }

    }
}
