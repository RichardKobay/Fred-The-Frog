using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class NextLevel : MonoBehaviour
{
    public Text levelCleared;
    public Text bestScore;

    // transitin variable
    public GameObject transition;

    //animator variable
    public Animator animator;


    // Detects the player and shange the scene
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player")){
            if(NextLevelKey.key == true)
            {
                //levelCleared.gameObject.SetActive(true);
                //transition.SetActive(true);
                Invoke("ChangeScene", 1);
                animator.SetBool("DoorOpen",true);
                PlayerPrefs.SetInt("BestScore", LevelScore.levelScoreInt);
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
