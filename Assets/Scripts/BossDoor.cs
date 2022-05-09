using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BossDoor : MonoBehaviour
{
    public Text levelCleared;
    
    public GameObject transition;

    public Animator animator;

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player")){
            if(BossKey.key == true)
            {
                //levelCleared.gameObject.SetActive(true);
                //transition.SetActive(true);
                Invoke("ChangeScene", 1);
                animator.SetBool("DoorOpen",true);

            }
            else
            {
                Debug.Log("Find The key");
            }
        }
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        NextLevelKey.key = false;
    }
}
