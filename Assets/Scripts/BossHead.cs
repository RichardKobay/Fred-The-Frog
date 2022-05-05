using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHead : MonoBehaviour
{
    public int life= 10;

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.transform.CompareTag("Player")){
            Debug.Log("Player Damaged");
            collision.transform.GetComponent<PlayerRespawn>().PlayerDamaged();
            NextLevelKey.key = false;
        }
            if(collision.transform.CompareTag("Spike")){
            Debug.Log("Boss Damaged");
            life= life -10;
            
        }
        
    }
    
}
