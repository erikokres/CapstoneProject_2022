using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gempa : MonoBehaviour
{
    int arah = 1;
    Rigidbody rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    public void gempa()
    {
        rig.AddForce(new Vector3(0, 3 * GameManager.nilaigempa * Time.deltaTime, 0), ForceMode.VelocityChange);
        rig.AddRelativeTorque(new Vector3(Random.Range(-1, 2)*.3f, 0, 0));
    }

    public void gempaNonr()
    {
        transform.rotation = Quaternion.Euler(Vector3.Slerp(new Vector3(Random.Range(-1f, 2f), 0, Random.Range(-1f, 2f)),
            new Vector3(Random.Range(-1f, 2f), 0, Random.Range(-1f, 2f)), GameManager.nilaigempa));
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.tag == "Tanah")
        {
            gempa();
        }
    }


}
