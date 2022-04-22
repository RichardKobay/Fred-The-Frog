using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{

    // Door variables
    public Text text;
    public string levelName;
    private bool inDoor = false;

    // Door collision void enter 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //text.gameObject.SetActive(true);
            inDoor = true;
            //animator.SetBool("DoorOpen", true);
        }
    }

    // Door collision void exit
    private void OnTriggerExit2D(Collider2D collision)
    {
        //text.gameObject.SetActive(false);
        inDoor = false;
        //animator.SetBool("DoorOpen", false);
    }

    private void Update()
    {
        if (inDoor && Input.GetKey("e"))
        {
            SceneManager.LoadScene(levelName);
        }
    }
}
