using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossHead : MonoBehaviour
{
    //hiteffect variable
    public GameObject HitEffect;
    //Color variable
    Color m_NewColor;
    //SpriteRenderer variable
    SpriteRenderer m_SpriteRenderer;
    //variable life of the boss
    public static int life= 100;

    //the boss begins with 100 porcent of life
    void Start(){
        life=100;
    }

    //the boss kills the player
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.transform.CompareTag("Player")){
            Debug.Log("Player Damaged");
            collision.transform.GetComponent<PlayerRespawn>().PlayerDamaged();
            NextLevelKey.key = false;
            HitEffect.gameObject.SetActive(false);
        }
          
        
    }

    //the boss is dead, the end cinematic begins
    void Update(){
        if (life<=0){
            SceneManager.LoadScene("EndCinematic");
        }
    }
    
}
