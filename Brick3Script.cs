using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick3Script : MonoBehaviour
{

    public ballScript ball;
    public GameObject redBrick;

    //importing data
    void Start()
    {
        ball = GameObject.FindWithTag("Ball").GetComponent<ballScript>();
    }

    //when this one breaks, it is being replaced with a 2-level one.
    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ball")
        {
            Destroy(this.gameObject);
            Instantiate(GameObject.Find("BlueBrick"), transform.position, transform.rotation);
        }

    }

}
