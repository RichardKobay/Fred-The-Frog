using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Portal2 : MonoBehaviour
{
    //fred enter in the portal of the easter egg 2
    private void OnTriggerEnter2D(Collider2D collision){
        if(EECinematic.EasterEgg1Reached){
            Destroy(gameObject);
        }
        if(collision.CompareTag("Player")){
            SceneManager.LoadScene("ProjectS");
        }
    }
}
