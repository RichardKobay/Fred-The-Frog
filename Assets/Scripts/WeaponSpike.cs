using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSpike : MonoBehaviour
{
    //Spike variable
    private bool touchSpike = false;

    //Animator variable
    public Animator animator;

    // Spike collision void enter 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
            touchSpike = true;
            
        }
    }

    // Spike collision void exit
    private void OnTriggerExit2D(Collider2D collision)
    {
        
        touchSpike = false;
        
    }

    private void Update()
    {
        if (touchSpike && Input.GetKey("e"))
        {
            animator.SetBool("Fall",true);
            Invoke("reset",4);
            
        }
    }
    void reset(){
        animator.SetBool("Fall", false);

    }
}
