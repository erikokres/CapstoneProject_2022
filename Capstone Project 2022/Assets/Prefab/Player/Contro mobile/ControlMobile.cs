using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMobile : MonoBehaviour
{
    public FloatingJoystick joy;
    Player player;

    void Start()
    {
        player = GetComponent<Player>();
    }

    void Update()
    {
        player.Jalan(joy.Horizontal, joy.Vertical);
        player.Gravitasi();
    }
}
