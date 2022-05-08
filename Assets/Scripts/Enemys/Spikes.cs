using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spikes : MonoBehaviour
{

    //the spikes kills the player
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.transform.CompareTag("Player")){
            Debug.Log("Player Damaged");
            collision.transform.GetComponent<PlayerRespawn>().PlayerDamaged();
            NextLevelKey.key = false;
           
        }
    }
}
