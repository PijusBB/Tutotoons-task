using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class button_duplicator : MonoBehaviour
{
    public GameObject pointOriginal;
    public Transform pointContainer;
    int place = 0;

    public void CreatePoints(int coinsnum)
    {
        for (int i = 0; i < coinsnum; i++)
        {
            GameObject PointClone = Instantiate(pointOriginal, new Vector3(0,0, 0), Quaternion.identity);
            PointClone.transform.SetParent(pointContainer);
            PointClone.name = ""+place++;
        }

    }
}
