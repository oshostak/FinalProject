using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddleScript : MonoBehaviour
{
    public float paddleSpeed;
    public Rigidbody2D rb;
    public float maxX;

// in update functions, which is performed every frame, I've specified the moing algorithm conditions

    private void Update()
    {
        float x = Input.GetAxis ("Horizontal"); // Inputing data from Horizontal axis - Event System in Unity

        if (x > 0) 
        {
            MoveRight();
        }

        if (x < 0) 
        {
            MoveLeft();
        }

        if (x == 0)
        {
            Stop();
        }

        Vector2 pos = transform.position;

        pos.x = Mathf.Clamp(pos.x, -maxX, maxX); // This states a limit for the paddle's movement. Its acccessible through Unity

        transform.position = pos;

    }

    //calling three methods for the paddle's movement. I used the change in velocity instead of using force, that's why sometimes it slides a bit.

    void MoveLeft()
    {
        rb.velocity = new Vector2(-paddleSpeed, 0f);
    }

    void MoveRight()
    {
        rb.velocity = new Vector2(paddleSpeed,0f);
    }

    void Stop()
    {
        rb.velocity = new Vector2(0f, 0f);
    }

}
