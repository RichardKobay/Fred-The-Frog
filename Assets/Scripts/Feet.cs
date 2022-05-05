using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feet : MonoBehaviour
{
    public Animator animator;
    public float time = 0;
    
    public bool a=true;
    void Update(){
        if(a){
Invoke("wait",1);
            a=false;
        }
        
    }

    void begin(){
        
        
        switch(Boss.attack)
        {
        
        case 3: 
        
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
