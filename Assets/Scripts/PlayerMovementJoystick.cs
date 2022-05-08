using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementJoystick : MonoBehaviour
{
    // RigidBody variable
    Rigidbody2D rb2D;

    // Player movement variables
    public float runSpeed = 2;
    public float jumpSpeed = 3.4f;

    // Better jump variables
    public bool betterJump = false;
    public float fallMultiplier = 0.5f;
    public float lowJumpMultipler = 1;

    //Double Jump Variables
    public float doubleJumpSpeed = 2.5f;
    private bool canDoubleJump;

    // Animation variables
    public SpriteRenderer spriteRenderer;
    public Animator animator;

    // Joystick reference and variables
    private float horizontalMovement = 0;
    private float verticalMovement = 0;
    public Joystick joystick;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    //Update used for the right functioning of the Double Jump
    private void Update()
    {

        // Player laft & right momement
        if (horizontalMovement > 0)
        {
            spriteRenderer.flipX = false;
            animator.SetBool("Run", true);
        }
        else if (horizontalMovement < 0)
        {
            spriteRenderer.flipX = true;
            animator.SetBool("Run", true);
        }
        else
        {
            animator.SetBool("Run", false);
        }

        // Cancel fred's movement if animation is on
        if (Soriano.onCinematic == false)
        {
            // checkground detects another gameObject
            if (CheckGround.isGrounded == false)
            {
                animator.SetBool("Jump", true);
                animator.SetBool("Run", false);
            }
            if (CheckGround.isGrounded == true)
            {
                animator.SetBool("Jump", false);
                animator.SetBool("DoubleJump", false);
                animator.SetBool("Falling", false);
            }

            //Makes the player know when its falling (y velocity is less than 0) or jumping (y velocity is more than 0)
            if (rb2D.velocity.y < 0)
            {
                animator.SetBool("Falling", true);
            }
            else if (rb2D.velocity.y > 0)
            {
                animator.SetBool("Falling", false);
            }
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Joystick movement
        horizontalMovement = joystick.Horizontal * runSpeed;
        transform.position += new Vector3(horizontalMovement, 0, 0) * Time.deltaTime * runSpeed;

        // Detects if Cinematic is on
        if (Soriano.onCinematic == false)
        {
            // Better Jump
            if (betterJump)
            {
                if (rb2D.velocity.y < 0)
                {
                    rb2D.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier) * Time.deltaTime;
                }

                if (rb2D.velocity.y > 0)
                {
                    rb2D.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultipler) * Time.deltaTime;
                }
            }
        }
    }

    // Jump void
    public void Jump()
    {
        if (CheckGround.isGrounded)
        {
            canDoubleJump = true;
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
        }
        else
        {
            if (canDoubleJump)
            {
                animator.SetBool("DoubleJump", true);
                rb2D.velocity = new Vector2(rb2D.velocity.x, doubleJumpSpeed);
                canDoubleJump = false;
            }
        }
    }
}
