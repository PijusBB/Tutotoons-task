using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class Duplicator : MonoBehaviour
{
    public GameObject pointOriginal;
    public Transform pointContainer;
    int place = 0;

    public void CreatePoints(int [] coinsnum)
    {
        for (int i = 0; i < coinsnum.Length ; i+=2)
        {
            GameObject PointClone = Instantiate(pointOriginal, new Vector3(coinsnum[i], -coinsnum[i+1], 0), Quaternion.identity);
            PointClone.transform.SetParent(pointContainer);
            PointClone.name = "" + place++;
        }

    }
}
