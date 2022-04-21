using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelKey : MonoBehaviour
{
    public static bool key = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Compàres the fruit with the player tag
        if (collision.CompareTag("Player"))
        {
            GetComponent<SpriteRenderer>().enabled = false;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            Destroy(gameObject, 0.5f);
            key = true;
            Debug.Log("Llave a");
        }
    }
}
