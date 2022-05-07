using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSpike : MonoBehaviour
{
    
    //Animator variable
    public Animator animator;

    // Spike collision void enter 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            animator.SetBool("Fall",true);
            Invoke("reset",4);
        }
        if(collision.transform.CompareTag("BossHead")){
            BossHead.life= BossHead.life-1;
            Debug.Log(BossHead.life);
            
        }
    }

    
    void reset(){
        animator.SetBool("Fall", false);

    }
    
}
