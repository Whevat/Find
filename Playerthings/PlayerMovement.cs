using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GroundCheck gC;

    private float horizontal;
    private float speed = 6f;
    private float jumpingPower = 8f;
    float buttonTime = .3f;
    float jumpTime;
    bool jumping;
    private bool isFacingRight = true;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

// Vertical Movement (Jumping)
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space) && gC.IsGrounded)
        {
            jumping = true;
            jumpTime = 0;
        }
        if (jumping)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
            jumpTime += Time.deltaTime;
        }
        if(Input.GetKeyUp(KeyCode.Space) || jumpTime > buttonTime)
        {
            jumping = false;
        }
        Flip();
    }

// Horizontal Movement
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);  
    }
  

// Flips the player's sprite when you move the other direction
    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
