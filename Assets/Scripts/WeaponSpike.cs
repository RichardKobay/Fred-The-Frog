using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSpike : MonoBehaviour
{
    public GameObject HitEffect;
    //Animator variable
    public Animator animator;

    // Spike collision void enter 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //the spike falls
        if (collision.gameObject.CompareTag("Player"))
        {
            animator.SetBool("Fall",true);
            Invoke("reset",4);
        }

        //the spike hurts the head of the boss
        if(collision.transform.CompareTag("BossHead")){
            BossHead.life= BossHead.life-1;
            Debug.Log(BossHead.life);
            HitEffect.gameObject.SetActive(true);
            Invoke("EffectFinished",0.4f);
        }
    }

    //the spike back to the start
    void reset(){
        animator.SetBool("Fall", false);

    }
    void EffectFinished(){
        HitEffect.gameObject.SetActive(false);
    }
    
}
