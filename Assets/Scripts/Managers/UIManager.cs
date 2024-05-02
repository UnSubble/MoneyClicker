using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private MoneyManager _moneyManager; ButtonManager buttonmanager;

    [SerializeField]
    public
    TextMeshProUGUI moneytext, bankcount, nuclearcount, oilcount, bankfee, oilfee, nuclearfee, taxpay, billpay, employeepay, rentpay;


    Transform paysmenu,farmmenu,settingsmenu,currencymenu,moneymenu,storemenu;

    [SerializeField] public
    TextMeshProUGUI dollarcount, dollarinstant, eurocount, euroinstant, bitcoincount, bitcoininstant;

   


    public static UIManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;

        //MENUS TRANSFORM
        paysmenu = GameObject.Find("PaysMenu").GetComponent<Transform>();
        farmmenu= GameObject.Find("FarmMenu").GetComponent<Transform>();
        settingsmenu= GameObject.Find("SettingsMenu").GetComponent<Transform>();
        currencymenu= GameObject.Find("CurrencyMenu").GetComponent<Transform>();
        moneymenu= GameObject.Find("MoneyMenu").GetComponent<Transform>();
        storemenu=GameObject.Find("StoreMenu").GetComponent<Transform>();


        //FARM MENU TEXTS
        bankcount = GameObject.Find("BankCount").GetComponent<TextMeshProUGUI>();
        oilcount = GameObject.Find("GasolineCount").GetComponent<TextMeshProUGUI>();
        nuclearcount = GameObject.Find("NuclearCount").GetComponent<TextMeshProUGUI>();


        //CURRENCY MENU TEXTS
        dollarcount= GameObject.Find("DollarCount").GetComponent<TextMeshProUGUI>();
        dollarinstant = GameObject.Find("InstantDollar").GetComponent<TextMeshProUGUI>();
        eurocount = GameObject.Find("EuroCount").GetComponent<TextMeshProUGUI>();
        euroinstant = GameObject.Find("InstantEuro").GetComponent<TextMeshProUGUI>();
        bitcoincount = GameObject.Find("BitcoinCount").GetComponent<TextMeshProUGUI>();
        bitcoininstant = GameObject.Find("InstantBitcoin").GetComponent<TextMeshProUGUI>();



    }

    void Start()
    {
        //StartCoroutine(CheckMoney());
        _moneyManager = GameManager.Instance.MoneyManager;
        buttonmanager = GameManager.Instance.ButtonManager;

        moneytext = GameObject.Find("TotalMoney").GetComponent<TextMeshProUGUI>();

        bankfee = GameObject.Find("BankExpensesTxt").GetComponent<TextMeshProUGUI>();
        oilfee = GameObject.Find("GasolineExpensesTxt").GetComponent<TextMeshProUGUI>();
        nuclearfee = GameObject.Find("NuclearExpensesTxt").GetComponent<TextMeshProUGUI>();


        //PAYS TEXT
        taxpay = GameObject.Find("TaxExpensesTxt").GetComponent<TextMeshProUGUI>();
        rentpay = GameObject.Find("RentExpensesTxt").GetComponent<TextMeshProUGUI>();
        employeepay = GameObject.Find("EmployeeExpensesTxt").GetComponent<TextMeshProUGUI>();
        billpay = GameObject.Find("BillExpensesTxt").GetComponent<TextMeshProUGUI>();

        


    }

    void Update()
    {
        moneytext.text = _moneyManager.GetTotalMoney() +" TL";

        
        eurocount.text = AAmountPool.euroamount.ToString();
        bitcoincount.text=AAmountPool.bitcoinamount.ToString();

        

    }
    Vector2 SetPos()
    {
        return new Vector2(1000, 0);
    }

    public void UpdateDollarCount()=> dollarcount.text = AAmountPool.dolaramount.ToSafeString() ;

    public void UpdateBitcoinCount() => bitcoincount.text = AAmountPool.bitcoinamount.ToSafeString() ;

    public void UpdateEuroCount()=>eurocount.text= AAmountPool.euroamount.ToString();



    public void PaysMenu()
    {
        paysmenu.position = Vector2.zero;
        currencymenu.position=SetPos();
        settingsmenu.position = SetPos();
        farmmenu.position = SetPos();
        moneymenu.position = SetPos();
        storemenu.position = SetPos();


    }

    public void MoneyMenu()
    {
        paysmenu.position = SetPos();
        currencymenu.position = SetPos();
        settingsmenu.position = SetPos();
        farmmenu.position = SetPos();
        moneymenu.position = Vector2.zero;
        storemenu.position = SetPos();

    }

    public void CurrencyMenu()
    {
        paysmenu.position = SetPos();
        currencymenu.position = Vector2.zero;
        settingsmenu.position = SetPos();
        farmmenu.position = SetPos();
        moneymenu.position = SetPos();
        storemenu.position = SetPos();

    }

    public void SettingsMenu()
    {
        paysmenu.position = SetPos();
        currencymenu.position = SetPos();
        settingsmenu.position = Vector2.zero;
        farmmenu.position = SetPos();
        moneymenu.position = SetPos();
        storemenu.position = SetPos();

    }

    public void FarmMenu()
    {
        paysmenu.position = SetPos();
        currencymenu.position = SetPos();
        settingsmenu.position = SetPos();
        farmmenu.position = Vector2.zero;
        moneymenu.position = SetPos();
        storemenu.position = SetPos();

    }

    public void StoreMenu()
    {
        paysmenu.position = SetPos();
        currencymenu.position = SetPos();
        settingsmenu.position = SetPos();
        farmmenu.position = SetPos() ;
        moneymenu.position = SetPos();
        storemenu.position = Vector2.zero;
    }



    public void UpdateMoney() => AAmountPool.money += 1;








}
