using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager:MonoBehaviour
{
    public float money = 0;

    public float dollarinstant = 10;

    public float euroinstant = 15;

    public float bitcoininstant = 100;

    public float dollaramount =0;

    public float euroamount = 0;

    public float bitcoinamount = 0;

    public float taxpay = 0;

    public float rentpay = 0;

    public float billpay = 0;

    public float employeepay = 0;

    public float bankcount = 0;

    public float bankfee = 50f;

    public float gasolinecount = 0;

    public float gasolinefee = 10f;

    public float nuclearcount = 0;

    public float nuclearfee = 30f;

    public float clickcountfee = 500f;

    public float clickcount = 1f;

    public float autoclickfee = 700f;

    public float autoclickcount = 0;




    public static PoolManager Instance { get; private set; }

    private void Awake()=> Instance = this;

    

    float autoupdatemoneycooldown = 0, timer = .5f;

    void Update()
    {
        if(Time.time - autoupdatemoneycooldown > timer)
        {
            money += autoclickcount;
            autoupdatemoneycooldown = Time.time;
        }
        
    }




}


