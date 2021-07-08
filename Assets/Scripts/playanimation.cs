using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class playanimation : MonoBehaviour
{
    Animator anim;
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    private int ObjectsNumber;
    private bool ClickWaiting;

    void Update()
    {
        if(ClickWaiting == true && timer.timeCount > 1) // Vykdomas queue
        {
            FindObjectOfType<linedrawer>().Addpoint(this.transform);
            timer.timeCount = 0;
            ClickWaiting = false;
        }
        if (linedrawer.pointqueue == JsonReader.length && timer.timeCount > 1) // Ieškau paskutinio nario
        {

            FindObjectOfType<linedrawer>().Addpoint(transform.parent.gameObject.transform.GetChild(0));
        }
    }


    void Start()
    {
        ObjectsNumber = 0;
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        anim = gameObject.GetComponentInChildren<Animator>();
        ObjectsNumber = Int32.Parse(this.gameObject.name);
    }
    void OnMouseDown()
    {
        if (linedrawer.pointqueue == ObjectsNumber) // Tikrina ar paspautas teisingas objektas
        {
            spriteRenderer.sprite = (newSprite);
            anim.SetTrigger("Doanimation"); // Iš karto paleidžiama animacija
            ClickWaiting = true;  
            if (timer.timeCount > 1 || ObjectsNumber == 0  || ObjectsNumber == 1) // Tikrina ar nevykdoma animacija, 0,1 objektam queue negalioja
            {
                FindObjectOfType<linedrawer>().Addpoint(this.transform);
                timer.timeCount = 0;
                ClickWaiting = false;
            }
        }

    }

}
