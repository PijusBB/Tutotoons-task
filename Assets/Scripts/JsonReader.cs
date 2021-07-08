using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
public class JsonReader : MonoBehaviour
{
    public static int length;
    public TextAsset textJSON;
    public Duplicator duplicator;

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
        duplicator.CreatePoints(mylevellist.levels[levelselector.whichlvltosummon].level_data);
        length = mylevellist.levels[levelselector.whichlvltosummon].level_data.Length / 2;
    }
}