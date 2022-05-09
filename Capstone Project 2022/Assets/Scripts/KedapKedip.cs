using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class KedapKedip : MonoBehaviour
{
    public float Durasi;
    float waktunya;
    public UnityEvent eventnya;

    void Start()
    {
        waktunya = Durasi;
    }

    void FixedUpdate()
    {
        waktunya-=Time.deltaTime;
        if (waktunya <= 0)
        {
            eventnya.Invoke();
            waktunya = Durasi;
        }
    }
}
