using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soriano : MonoBehaviour
{
    //cinematic variable
    public static bool onCinematic = false;

    //Soriano's variable
    private bool touchSori = false;

    //interact action
    public bool interact = false;

    // Character collision void enter 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
            touchSori = true;
            
        }
    }

    // Character collision void exit
    private void OnTriggerExit2D(Collider2D collision)
    {
        
        touchSori = false;
        
    }

    private void Update()
    {
        if (touchSori && Input.GetKey("e"))
        {
            onCinematic = true;
            
        }
        
    }
    public void Interact(){
        if(touchSori){
            onCinematic = true;
        }
    }
}
