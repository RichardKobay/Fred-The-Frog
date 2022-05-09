using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementJoystick : MonoBehaviour
{

    // Joystick movement variables
    private float horizontalMovement = 0;
    private float runSpeedHorizontal = 2;

    // Joystick reference
    public Joystick joystick;

    // Player movement variables
    public float runSpeed = 2;
    public float jumpSpeed = 3.4f;

    // RigidBody variable
    Rigidbody2D rb2D;

    //Double Jump Variables
    public float doubleJumpSpeed = 2.5f;
    private bool canDoubleJump;

    // Animation variables
    //public SpriteRenderer spriteRenderer;
    public SpriteRenderer spriteRenderer;

    //public Animator animator;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    //Update used for the right functioning of the Double Jump
    private void Update()
    {
        //don'n move in the cinematic
        if (Soriano.onCinematic == false){
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

        //fred don't move if an cinematic is on
        if (Soriano.onCinematic == false)
        {
            //checkground detects another gameObject
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
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //don't move in the cinematic
        if (Soriano.onCinematic == false){
        // Joystick horizontal movement
        horizontalMovement = joystick.Horizontal * runSpeedHorizontal;
        transform.position += new Vector3(horizontalMovement, 0, 0) * Time.deltaTime * runSpeed;
        }
    }

    // Joystick Jump function
    public void Jump()
    {
        //dont move in the cinematic
        if (Soriano.onCinematic == false){
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

}
