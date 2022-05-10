using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]

public class Player : MonoBehaviour
{
    CharacterController player;

    float gravitasi;

    public bool napak;
    public float Kecepatan;
    public float KekuatanLoncat;

    void Awake()
    {
        player = GetComponent<CharacterController>();
    }

    private void Update()
    {
        napak = Physics.CheckSphere(transform.position - new Vector3(0, 1f, 0), .1f);
    }

    public void Jalan(float ArahX,float ArahZ)
    {
        player.Move(transform.forward *ArahZ *Kecepatan);
        player.Move(transform.right * ArahX * Kecepatan);
    }

    public void Gravitasi()
    {
        if (napak == true)
        {
            player.Move(new Vector3(0, -gravitasi, 0));
        }
        else
        {
            gravitasi += 9 * Time.deltaTime;
            player.Move(new Vector3(0, -gravitasi * Time.deltaTime, 0));
        }
    }



}
