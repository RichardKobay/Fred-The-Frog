using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossKey : MonoBehaviour
{
    public GameObject Activate;
    
    public static bool key = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Comp�res the fruit with the player tag
        if (collision.CompareTag("Player"))
        {
            GetComponent<SpriteRenderer>().enabled = false;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            Destroy(gameObject, 0.5f);
            Activate.SetActive(true);
            key = true;
            Debug.Log("Llave a");
        }
    }
}
