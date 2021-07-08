using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class TextChanger : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI m_Object;
    void Start()
    {
        string parentName = transform.parent.name;
        string number="";
        for (int i = 0; i < parentName.Length; i++)
        {
            if (Char.IsDigit(parentName[i]))
            {
                number += parentName[i];
            }

        }
        m_Object.text = number;
    }
}
