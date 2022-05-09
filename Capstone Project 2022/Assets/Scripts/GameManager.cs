using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float IntesitasGempa;
    public static float nilaigempa;

    private void Update()
    {
        nilaigempa = IntesitasGempa;
    }
}
