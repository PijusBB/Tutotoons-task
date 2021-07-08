using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
public class buttonscript : MonoBehaviour
{

    public TextAsset textJSON;
    public button_duplicator Buttonduplicator;

    [System.Serializable]
    public class Leveldata
    {
        public int[] level_data;
    }

    [System.Serializable]
    public class Levellist
    {
        public Leveldata[] levels;
    }

    public Levellist mylevellist = new Levellist();

    void Start()
    {
        mylevellist = JsonUtility.FromJson<Levellist>(textJSON.text);
        int length = mylevellist.levels.Length;
        Buttonduplicator.CreatePoints(length);
    }
}