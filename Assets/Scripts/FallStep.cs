using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallStep : MonoBehaviour
{
    //Waiting time and Reapearing time (input in the editor as components inside the script fields)
    [SerializeField] private float WaitingTime;
    [SerializeField] private float ReapearingTime;    

    //Definition of private and public variables
    private Rigidbody2D rBody2D;
    private Vector3 posIni;
    public Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        rBody2D = GetComponent<Rigidbody2D>();
        posIni = transform.position;        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // On collision with the player Invokes "Fall" and "Reapearing" with their respective times
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Invoke("Fall", WaitingTime);
            Invoke("Reapearing", ReapearingTime);
        }
    }

    // Makes the platform fall
    private void Fall()
    {
       rBody2D.isKinematic = false;
       animator.SetBool("Falling", true);
    }

    // Makes the platform reapear in the initial position before it fell
    private void Reapearing()
    {
       rBody2D.velocity = Vector3.zero;
       rBody2D.isKinematic = true;
       transform.position = posIni;
       animator.SetBool("Falling", false);

    }
    
}
