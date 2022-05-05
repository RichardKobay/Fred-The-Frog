using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public Animator animator;
    public float time = 0;
    public static int attack=0;
    public bool a=true;
    void Update(){
        if(a){
Invoke("wait",1);
            a=false;
        }
        
    }

    void begin(){
        
        if (attack==4){
            attack = 0;
        }
        attack= attack + 1;
        
        switch(attack)
        {
        case 1: 
            Debug.Log("a");
            animator.SetBool("attack1", true);
            Invoke("wait", 10);
            
            break;
        case 2: 
        Debug.Log("aa");
            animator.SetBool("attack2", true);
            Invoke("wait", 10);
            break;
        case 3: 
        Debug.Log("aaa");
            animator.SetBool("attack3", true);
            Invoke("wait", 10);
            break;
        case 4: 
        Debug.Log("aaaa");
            animator.SetBool("attack4", true);
            Invoke("wait", 1.3f);
            break;
        default:

            break;
}
        
    }
    void wait(){
        animator.SetBool("attack1", false);
        animator.SetBool("attack2", false);
        animator.SetBool("attack3", false);
        animator.SetBool("attack4", false);
        Invoke("begin",10);
    }
}
