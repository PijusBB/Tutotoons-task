using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class timer : MonoBehaviour
{
    public static float timeCount; 
    void Update()
    {
        timeCount += Time.deltaTime;
    }
}
