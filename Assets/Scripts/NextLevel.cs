using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class NextLevel : MonoBehaviour
{
    public Text levelCleared;

    //the flag detects the Player
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player")){
            levelCleared.gameObject.SetActive(true);
            Invoke("ChangeScene", 1);
        }
    }
    //level change
    void ChangeScene(){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
}
