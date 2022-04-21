using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class FruitManager : MonoBehaviour
{
    //when the FruitManager no longer has children
    public Text levelCleared;
    public void AllFruitsCollected(){
        if(transform.childCount == 1){
            Debug.Log("No quedan frutas, Victoria");
            levelCleared.gameObject.SetActive(true);
            Invoke("ChangeScene", 1);
        }
        
    }
    //level change
    void ChangeScene(){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
}
