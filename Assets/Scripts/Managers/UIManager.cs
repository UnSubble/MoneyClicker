using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{


    [SerializeField]
    TextMeshProUGUI moneytext, bankcount, nuclearcount, gasolinefee, bankfee, gasolinecount, nuclearfee, taxpay, billpay, employeepay, rentpay;


    Transform paysmenu, farmmenu, buildmenu, currencymenu, moneymenu, storemenu;

    [SerializeField]
    TextMeshProUGUI dollarcount, dollarinstant, eurocount, euroinstant, bitcoincount, bitcoininstant;

    [SerializeField]
    TextMeshProUGUI clickcountfee, clickcount, autoclick, autoclickfee;

    Transform nuclearinfomenu,gasolineinfomenu, bankinfomenu;

    Transform dollarinfomenu, euroinfomenu, bitcoininfomenu;

    GameObject[] menus,infomenus;

    public bool isinfomenuopen;

    

    public static UIManager Instance { get; private set; }


    private void Awake()
    {
        Instance = this;

        //MENUS TRANSFORM
        paysmenu = GameObject.Find("PaysMenu").GetComponent<Transform>();
        farmmenu = GameObject.Find("FarmMenu").GetComponent<Transform>();
        currencymenu = GameObject.Find("CurrencyMenu").GetComponent<Transform>();
        moneymenu = GameObject.Find("MoneyMenu").GetComponent<Transform>();
        storemenu = GameObject.Find("StoreMenu").GetComponent<Transform>();
        buildmenu = GameObject.Find("BuildMenu").GetComponent<Transform>();
        bankinfomenu= GameObject.Find("BankInfoMenu").GetComponent<Transform>();
        gasolineinfomenu = GameObject.Find("GasolineInfoMenu").GetComponent<Transform>();
        nuclearinfomenu = GameObject.Find("NuclearInfoMenu").GetComponent<Transform>();
        dollarinfomenu = GameObject.Find("DollarInfoMenu").GetComponent<Transform>();
        euroinfomenu = GameObject.Find("EuroInfoMenu").GetComponent<Transform>();
        bitcoininfomenu = GameObject.Find("BitcoinInfoMenu").GetComponent<Transform>();




        //FARM MENU TEXTS
        bankcount = GameObject.Find("BankCount").GetComponent<TextMeshProUGUI>();
        gasolinecount = GameObject.Find("GasolineCount").GetComponent<TextMeshProUGUI>();
        nuclearcount = GameObject.Find("NuclearCount").GetComponent<TextMeshProUGUI>();


        //CURRENCY MENU TEXTS
        dollarcount = GameObject.Find("DollarCount").GetComponent<TextMeshProUGUI>();
        dollarinstant = GameObject.Find("InstantDollar").GetComponent<TextMeshProUGUI>();
        eurocount = GameObject.Find("EuroCount").GetComponent<TextMeshProUGUI>();
        euroinstant = GameObject.Find("InstantEuro").GetComponent<TextMeshProUGUI>();
        bitcoincount = GameObject.Find("BitcoinCount").GetComponent<TextMeshProUGUI>();
        bitcoininstant = GameObject.Find("InstantBitcoin").GetComponent<TextMeshProUGUI>();


        //STORE MENU TEXTS
        clickcountfee = GameObject.Find("ClickCountFee").GetComponent<TextMeshProUGUI>();
        clickcount = GameObject.Find("ClickCountTxt").GetComponent<TextMeshProUGUI>();
        autoclick = GameObject.Find("AutoClickTxt").GetComponent<TextMeshProUGUI>();
        autoclickfee = GameObject.Find("AutoClickFee").GetComponent<TextMeshProUGUI>();

       



    }

    void Start()
    {
        



        moneytext = GameObject.Find("TotalMoney").GetComponent<TextMeshProUGUI>();

        bankfee = GameObject.Find("BankExpensesTxt").GetComponent<TextMeshProUGUI>();
        gasolinefee = GameObject.Find("GasolineExpensesTxt").GetComponent<TextMeshProUGUI>();
        nuclearfee = GameObject.Find("NuclearExpensesTxt").GetComponent<TextMeshProUGUI>();


        //PAYS TEXT
        taxpay = GameObject.Find("TaxExpensesTxt").GetComponent<TextMeshProUGUI>();
        rentpay = GameObject.Find("RentExpensesTxt").GetComponent<TextMeshProUGUI>();
        employeepay = GameObject.Find("EmployeeExpensesTxt").GetComponent<TextMeshProUGUI>();
        billpay = GameObject.Find("BillExpensesTxt").GetComponent<TextMeshProUGUI>();

        menus = GameObject.FindGameObjectsWithTag("Menus");
        infomenus = GameObject.FindGameObjectsWithTag("InfoMenus");


    }

    void Update()
    {
        moneytext.text = GameManager.Instance.MoneyManager.GetTotalMoney() + " TL";

        dollarinstant.text = PoolManager.Instance.dollarinstant.ToString() + " TL";

        euroinstant.text = PoolManager.Instance.euroinstant.ToString() + " TL";

        bitcoininstant.text = PoolManager.Instance.bitcoininstant.ToString() + " TL";

        dollarcount.text = PoolManager.Instance.dollaramount.ToString() + " dolar";

        eurocount.text = PoolManager.Instance.euroamount.ToString() + " euro";

        bitcoincount.text = PoolManager.Instance.bitcoinamount.ToString() + " bitcoin";

        taxpay.text = PoolManager.Instance.taxpay.ToString() + " TL";

        rentpay.text = PoolManager.Instance.rentpay.ToString() + " TL";

        billpay.text = PoolManager.Instance.billpay.ToString() + " TL";

        employeepay.text = PoolManager.Instance.employeepay.ToString() + " TL";

        bankfee.text = PoolManager.Instance.bankfee.ToString() + " TL";

        bankcount.text = PoolManager.Instance.bankcount.ToString();

        nuclearcount.text = PoolManager.Instance.nuclearcount.ToString();

        nuclearfee.text = PoolManager.Instance.nuclearfee.ToString() + " TL";

        gasolinefee.text = PoolManager.Instance.gasolinefee.ToString() + " TL";

        gasolinecount.text = PoolManager.Instance.gasolinecount.ToString();

        autoclickfee.text = PoolManager.Instance.autoclickfee.ToString() + " TL";

        autoclick.text = PoolManager.Instance.autoclickcount.ToString();

        clickcount.text = PoolManager.Instance.clickcount.ToString();

        clickcountfee.text = PoolManager.Instance.clickcountfee.ToString() + " TL";

        


    }
    void MenusPos()
    {
        foreach (GameObject menu in menus)
        {
            menu.transform.position = new Vector2(1000, 0);
        }
    }

    void InfoMenusPos()
    {
        foreach (GameObject menu in infomenus)
        {
            menu.transform.position = new Vector2(1000, 0);
        }
    }





    public void PaysMenu()
    {
        MenusPos();
        paysmenu.position = Vector2.zero;


    }

    public void MoneyMenu()
    {

        MenusPos();
        moneymenu.position = Vector2.zero;


    }

    public void CurrencyMenu()
    {
        MenusPos();
        currencymenu.position = Vector2.zero;

    }

    public void BuildMenu()
    {
        MenusPos();
        buildmenu.position = Vector2.zero;

    }

    public void FarmMenu()
    {
        MenusPos();
        farmmenu.position = Vector2.zero;

    }

    public void StoreMenu()
    {
        MenusPos();
        storemenu.position = Vector2.zero;

    }

    public void BankInfo()
    {
        
        isinfomenuopen=true;
        InfoMenusPos();
        bankinfomenu.position = Vector2.zero;

    }
    public void GasolineInfo()
    {
        isinfomenuopen = true;
        InfoMenusPos();
        gasolineinfomenu.position = Vector2.zero;
    }
    public void Nuclearýnfo()
    {
        isinfomenuopen = true;
        InfoMenusPos();
        nuclearinfomenu.position = Vector2.zero;
        
    }







    public void CloseBankInfo()
    {
        isinfomenuopen = false;
        bankinfomenu.position = new Vector2(1000, 0);
    }
    public void CloseNuclearInfo()
    {
        isinfomenuopen = false;
        nuclearinfomenu.position = new Vector2(1000, 0);
    }
    public void CloseGasolineInfo()
    {
        isinfomenuopen = false;
        gasolineinfomenu.position = new Vector2(1000, 0);
    }















}
