using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelselector : MonoBehaviour
{
    public static int whichlvltosummon;
    public Button yourButton;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
     
        whichlvltosummon = Int32.Parse(this.gameObject.name);
        SceneManager.LoadScene("GamePlay");
    }


}
