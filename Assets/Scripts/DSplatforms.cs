using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DSplatforms : MonoBehaviour
{

    public bool Atrevezar=false;
    private float verticalMovement = 0;
    private float runSpeedvertical = 2;

    public Joystick joystick;
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
        if(Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp("s") || verticalMovement< 0)
        {
           WaitedTime = StartWaitTime;
        }

        if(Input.GetKey(KeyCode.DownArrow) || Input.GetKey("s") || verticalMovement< 0)
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

        if(Input.GetKey("space")||Atrevezar==true)
        {
            effector.rotationalOffset = 0f;
        }
    }
    void FixedUpdate()
    {
        // Joystick horizontal movement
        verticalMovement = joystick.Vertical * runSpeedvertical;
        
    }
    public void Jump()
    {
        
            effector.rotationalOffset = 0f;
    }
}
