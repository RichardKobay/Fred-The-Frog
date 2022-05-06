using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EECinematic : MonoBehaviour
{
    public static bool EasterEgg1Reached = false;
    //the cinematic begins
    void Update()
    {
        if(Soriano.onCinematic){
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            Invoke ("Cinematicoff",30);
            
        }
    }
    //the cinematic finish
    void Cinematicoff (){
        Debug.Log("Cinematic off"); 
            Soriano.onCinematic = false;
            SceneManager.LoadScene("Level1");
            NextLevelKey.key = false;
            EasterEgg1Reached = true;
    }
}
