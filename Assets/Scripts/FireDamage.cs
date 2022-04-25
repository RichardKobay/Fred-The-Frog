using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireDamage : MonoBehaviour
{

    [SerializeField] private float ONTime;
    [SerializeField] private float OFFTime;
    
    private Collider2D Coll2D;
    public Animator animator;
    private float counter = 0.0f;
    
    void Update()
    {
        Coll2D = GetComponent<Collider2D>();

        counter += Time.deltaTime;

        if(counter >= ONTime)
        {
            OnTriggerEnter2D(Coll2D);
            counter = 0.0f;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D trigger)
    {
        if(trigger.gameObject.tag == "Player")
        {
                if(trigger.transform.CompareTag("Player"))
                {
                Debug.Log("Player Damaged");
                trigger.transform.GetComponent<PlayerRespawn>().PlayerDamaged();
                }
        }
    }    
}
