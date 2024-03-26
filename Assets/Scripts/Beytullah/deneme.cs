using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class Deneme : MonoBehaviour
{
    public Text cointext, electricktext;

    float electricbill = 0, coincounter = 0, cooldown = 0;

    bool isclicker;

    void Start()
    {

    }


    void Update()
    {
        cointext.text = coincounter.ToString();
        if (Input.GetMouseButtonDown(0))
        {
            coincounter++;

        }
        electricktext.text = electricbill.ToString();
        if (Time.time - cooldown > .5f)
        {
            electricbill++;
            cooldown = Time.time;
        }


        
        

    }

    public void Reset()
    {
        if (coincounter >= electricbill)
        {
            coincounter -= electricbill;
            electricbill = 0;
        }
        else
        {
            Debug.Log("ödenemedi");
        }
    }

    
     













}
