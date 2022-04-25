using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DSplatforms : MonoBehaviour
{

    private PlatformEffector2D effector;

    public float StartWaitTime;
    private float WaitedTime;
    // Start is called before the first frame update
    void Start()
    {
        effector = GetComponent<PlatformEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp("s"))
        {
           WaitedTime = StartWaitTime;
        }

        if(Input.GetKey(KeyCode.DownArrow) || Input.GetKey("s"))
        {
            if(WaitedTime <= 0)
            {
                effector.rotationalOffset = 180f;
                WaitedTime = StartWaitTime;
            }else
            {
                WaitedTime -= Time.deltaTime;
            }
           
        }

        if(Input.GetKey("space"))
        {
            effector.rotationalOffset = 0f;
        }
    }
}
