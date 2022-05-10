using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMobile : MonoBehaviour
{
    public FloatingJoystick joy;
    AimMobile aim;
    Player player;

    void Start()
    {
        player = GetComponent<Player>();
        aim = GetComponentInChildren<AimMobile>();
    }


    void FixedUpdate()
    {
        player.Jalan(joy.Horizontal * Time.deltaTime, joy.Vertical * Time.deltaTime);
        player.Gravitasi();
    
    }
}
