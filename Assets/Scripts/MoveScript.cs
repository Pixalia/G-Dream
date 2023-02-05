using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour

    
{
    [SerializeField]
    private Rigidbody2D rb;

    [SerializeField]
    private Sprite[] playerSprites;


    private bool moving = false;
    private float horizontalVelocity = 0;
    private float verticalVelocity = 0;
    private float movespeed;


    // Start is called before the first frame update
    void Start()
    {
        movespeed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalVelocity = 0;
        verticalVelocity = 0;
        if (Input.GetKey(KeyCode.W))
        {
            verticalVelocity += movespeed;
            moving = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            horizontalVelocity -= movespeed;
            moving = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            verticalVelocity -= movespeed;
            moving = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            horizontalVelocity += movespeed;
            moving = true;
        }

        if (moving)
        {
            Debug.Log(horizontalVelocity);
            Debug.Log(verticalVelocity);
            rb.velocity = new Vector2(horizontalVelocity, verticalVelocity);
        }
    }
}
