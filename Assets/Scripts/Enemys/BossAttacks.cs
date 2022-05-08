using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttacks : MonoBehaviour
{
    //hiteffect variable
    public GameObject HitEffect;
    //the boss kills the player
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.transform.CompareTag("Player")){
            Debug.Log("Player Damaged");
            collision.transform.GetComponent<PlayerRespawn>().PlayerDamaged();
            NextLevelKey.key = false;
            HitEffect.gameObject.SetActive(false);
        }
    }
}
