using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabFPS : MonoBehaviour
{
    RaycastHit ray;
    public Transform tangan;
    [HideInInspector]
    public bool megang;

    public void Ambil()
    {
        Physics.Raycast(transform.localPosition, transform.forward, out ray);

        if (ray.collider.attachedRigidbody)
        {
            Rigidbody rig = ray.collider.attachedRigidbody;
            rig.AddForce(Vector3.Lerp(rig.transform.position,tangan.transform.position,.5f));
        }
    }
}
