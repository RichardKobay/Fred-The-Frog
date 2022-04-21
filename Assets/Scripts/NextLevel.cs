using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class NextLevel : MonoBehaviour
{
    public Text levelCleared;

    // transitin variable
    public GameObject transition;

    // Detects the player and shange the scene
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player")){
            if(NextLevelKey.key == true)
            {
                //levelCleared.gameObject.SetActive(true);
                //transition.SetActive(true);
                //Invoke("ChangeScene", 1);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

            }
            else
            {
                Debug.Log("Find The key");
            }
        }
    }

    void ChangeScene()
    {
    }
}
