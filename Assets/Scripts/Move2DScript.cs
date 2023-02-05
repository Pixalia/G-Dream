using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Move2DScript : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb;

    [SerializeField]
    private Sprite[] playerSprites;

    [SerializeField]
    private Transform groundCheck;

    [SerializeField]
    private LayerMask groundLayer;

    public Animator animator;

    private float horizontal;
    private float speed = 10f;
    private float jumpingSpeed = 20f;
    private bool rightFace;

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Jump") && isGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingSpeed);
        }

        if (Input.GetButtonDown("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

        Flip();
    }

    private void FixedUpdate()
    {
        
        
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
        animator.SetFloat("Horizontal", Math.Abs(horizontal));
        
        
    }

    private bool isGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void Flip()
    {
        if (rightFace && horizontal < 0f || !rightFace && horizontal > 0f)
        {
            rightFace = !rightFace;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Butterfly")
        {
            rb.velocity = new Vector2(0, 0);
        }
    }

}
