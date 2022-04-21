using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FruitManager : MonoBehaviour
{
    // Calls the AllFruitsCollected void every frame
    private void Update()
    {
        AllFruitsCollected();
    }

    // when the FruitManager no longer has children
    public Text levelCleared;
    public void AllFruitsCollected(){
        if(transform.childCount == 0){
            Debug.Log("No quedan frutas, Victoria");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
