using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBrickScript : MonoBehaviour
{

    public ballScript ball;
    public GameObject redBrick;

    // importin data
    void Start()
    {
        ball = GameObject.FindWithTag("Ball").GetComponent<ballScript>();
    }

    //Collision Detector. If a ball hits this block, the program destroys the object and generates a red block instead and puts it into an exact same location.
    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ball")
        {
            ball.collisionScore++;
            Destroy(this.gameObject);
            Instantiate(GameObject.Find("Brick1"), transform.position, transform.rotation);
        }
    }
}
