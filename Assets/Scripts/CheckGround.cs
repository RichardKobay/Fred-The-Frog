using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    public static bool isGrounded;
    //the CheckGround detects another gameObject
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isGrounded = true;
    }

    //the CheckGround doesn't detect an other gameObject
    private void OnTriggerExit2D(Collider2D collision)
    {
        isGrounded = false;
    }
}
