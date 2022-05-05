using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossHead : MonoBehaviour
{
    public static int life= 50;

    void Start(){
        life=50;
    }
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.transform.CompareTag("Player")){
            Debug.Log("Player Damaged");
            collision.transform.GetComponent<PlayerRespawn>().PlayerDamaged();
            NextLevelKey.key = false;
        }
            
        
    }
    void Update(){
        if (life<=0){
            SceneManager.LoadScene("EndCinematic");
        }
    }
    
}
