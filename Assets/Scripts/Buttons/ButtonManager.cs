using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;



public class ButtonManager : MonoBehaviour
{


    Button rentbutton, employeebutton, taxbutton, billbutton;

    Button moneymenubutton, farmmenubutton, currencymenubutton, paysmenubutton, storemenubutton;

    Button nuclear, gasoline, bank;

    Button bitcoin, dollar, euro;

    Button bitcoinimg, dollarimg, euroimg;

    Button autoclick, clickcount;

    Button bankinfo, nuclearinfo, gasolineinfo;

    Button voicesetting;

    Button closebankinfo, closenuclaerinfo, closegasolineinfo;



    public static ButtonManager Instance { get; private set; }


    public bool isclicked;

    public IEnumerator Clicked()
    {
        yield return new WaitForSeconds(.1f);
        isclicked = false;

    }



    void Start()
    {
        Instance = this;

        moneymenubutton = GameObject.Find("MoneyMenuButton").GetComponent<Button>();
        farmmenubutton = GameObject.Find("FarmMenuButton").GetComponent<Button>();
        currencymenubutton = GameObject.Find("CurrencyMenuButton").GetComponent<Button>();
        paysmenubutton = GameObject.Find("PaysMenuButton").GetComponent<Button>();
        storemenubutton = GameObject.Find("StoreMenuButton").GetComponent<Button>();

        bank = GameObject.Find("Bank").GetComponent<Button>();
        nuclear = GameObject.Find("Nuclear").GetComponent<Button>();
        gasoline = GameObject.Find("Gasoline").GetComponent<Button>();


        rentbutton = GameObject.Find("RentExpenses").GetComponent<Button>();
        employeebutton = GameObject.Find("EmployeeExpenses").GetComponent<Button>();
        taxbutton = GameObject.Find("TaxExpenses").GetComponent<Button>();
        billbutton = GameObject.Find("BillExpenses").GetComponent<Button>();


        dollar = GameObject.Find("Dollar").GetComponent<Button>();
        euro = GameObject.Find("Euro").GetComponent<Button>();
        bitcoin = GameObject.Find("Bitcoin").GetComponent<Button>();

        dollarimg = GameObject.Find("DollarImg").GetComponent<Button>();
        euroimg = GameObject.Find("EuroImg").GetComponent<Button>();
        bitcoinimg = GameObject.Find("BitcoinImg").GetComponent<Button>();

        autoclick = GameObject.Find("AutoClick").GetComponent<Button>();
        clickcount = GameObject.Find("ClickCount").GetComponent<Button>();


        gasolineinfo = GameObject.Find("GasolineInfo").GetComponent<Button>();
        bankinfo = GameObject.Find("BankInfo").GetComponent<Button>();
        nuclearinfo = GameObject.Find("NuclearInfo").GetComponent<Button>();


        voicesetting = GameObject.Find("VoiceSettingsButton").GetComponent<Button>();


        closebankinfo = GameObject.Find("BankInfoClose").GetComponent<Button>();
        closegasolineinfo = GameObject.Find("GasolineInfoClose").GetComponent<Button>();
        closenuclaerinfo = GameObject.Find("NuclearInfoClose").GetComponent<Button>();



        MenuToggleSound();
    }

    void MenuToggleSound()
    {
        GameObject[] menubuttons = GameObject.FindGameObjectsWithTag("Menubutton");

        foreach (GameObject button in menubuttons)
        {
            button.GetComponent<Button>().onClick.AddListener(() =>
            {
                AudioManager.Instance.PlayMenuToggleSound();

            });

        }
    }


    void Update()
    {


        //MENUS BUTTONS
        moneymenubutton.onClick.AddListener(() => UIManager.Instance.MoneyMenu());
        farmmenubutton.onClick.AddListener(() => UIManager.Instance.FarmMenu());
        currencymenubutton.onClick.AddListener(() => UIManager.Instance.CurrencyMenu());
        paysmenubutton.onClick.AddListener(() => UIManager.Instance.PaysMenu());
        
        storemenubutton.onClick.AddListener(() => UIManager.Instance.StoreMenu());

        //FARM MENU BUTTONS
        bank.onClick.AddListener(() => GameManager.Instance.FarmManager.BuyBank());
        nuclear.onClick.AddListener(() => GameManager.Instance.FarmManager.BuyNuclear());
        gasoline.onClick.AddListener(() => GameManager.Instance.FarmManager.BuyGasoline());

        //PAY MENU BUTTONS
        rentbutton.onClick.AddListener(() => GameManager.Instance.PayManager.ResetRentPay());
        employeebutton.onClick.AddListener(() => GameManager.Instance.PayManager.ResetEmployeePay());
        taxbutton.onClick.AddListener(() => GameManager.Instance.PayManager.ResetTaxPay());
        billbutton.onClick.AddListener(() => GameManager.Instance.PayManager.ResetBillPay());



        //CURRENCY MENU BUTTONS
        dollar.onClick.AddListener(() => GameManager.Instance.CurrencyManager.CurrencyDolar());
        euro.onClick.AddListener(() => GameManager.Instance.CurrencyManager.CurrencyEuro());
        bitcoin.onClick.AddListener(() => GameManager.Instance.CurrencyManager.CurrencyBitcoin());

        //STORE MENU BUTTONS
        autoclick.onClick.AddListener(() => GameManager.Instance.StoreManager.BuyAutoClick());
        clickcount.onClick.AddListener(() => GameManager.Instance.StoreManager.BuyClickCount());


        bankinfo.onClick.AddListener(() => GameManager.Instance.UIManager.BankInfo());
        gasolineinfo.onClick.AddListener(() => GameManager.Instance.UIManager.GasolineInfo());
        nuclearinfo.onClick.AddListener(() => GameManager.Instance.UIManager.Nuclearýnfo());




        closebankinfo.onClick.AddListener(() => GameManager.Instance.UIManager.CloseBankInfo());
        closegasolineinfo.onClick.AddListener(() => GameManager.Instance.UIManager.CloseGasolineInfo());
        closenuclaerinfo.onClick.AddListener(() => GameManager.Instance.UIManager.CloseNuclearInfo());




    }








}
