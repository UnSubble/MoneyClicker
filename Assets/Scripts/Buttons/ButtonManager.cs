using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class ButtonManager : MonoBehaviour
{

   
    Button rentbutton,employeebutton,taxbutton,billbutton;

    Button moneymenubutton, farmmenubutton, currencymenubutton, paysmenubutton, settingsmenubutton,storemenubutton;

    Button nuclear, gasoline, bank;

    Button bitcoin, dollar, euro;

    Button bitcoinimg, dollarimg,euroimg;
    
    
    
    public Toggle paysmenu;

   

    void Start()
    {
        

        moneymenubutton = GameObject.Find("MoneyMenuButton").GetComponent<Button>();
        farmmenubutton = GameObject.Find("FarmMenuButton").GetComponent<Button>();
        currencymenubutton = GameObject.Find("CurrencyMenuButton").GetComponent<Button>();
        paysmenubutton = GameObject.Find("PaysMenuButton").GetComponent<Button>();
        settingsmenubutton = GameObject.Find("SettingsMenuButton").GetComponent<Button>();
        storemenubutton = GameObject.Find("StoreMenuButton").GetComponent<Button>();

        bank= GameObject.Find("Bank").GetComponent<Button>();
        nuclear= GameObject.Find("Nuclear").GetComponent<Button>();
        gasoline= GameObject.Find("Gasoline").GetComponent<Button>();


        rentbutton= GameObject.Find("RentExpenses").GetComponent<Button>();
        employeebutton = GameObject.Find("EmployeeExpenses").GetComponent<Button>();
        taxbutton = GameObject.Find("TaxExpenses").GetComponent<Button>();
        billbutton   = GameObject.Find("BillExpenses").GetComponent<Button>();


        dollar= GameObject.Find("Dollar").GetComponent<Button>();
        euro= GameObject.Find("Euro").GetComponent<Button>();
        bitcoin=GameObject.Find("Bitcoin").GetComponent<Button>();

        dollarimg = GameObject.Find("DollarImg").GetComponent<Button>();
        euroimg = GameObject.Find("EuroImg").GetComponent<Button>();
        bitcoinimg = GameObject.Find("BitcoinImg").GetComponent<Button>();
    }


    void Update()
    {
        //MENUS BUTTONS
        moneymenubutton.onClick.AddListener(()=>UIManager.Instance.MoneyMenu());
        farmmenubutton.onClick.AddListener(() => UIManager.Instance.FarmMenu());
        currencymenubutton.onClick.AddListener(() => UIManager.Instance.CurrencyMenu());
        paysmenubutton.onClick.AddListener(() => UIManager.Instance.PaysMenu());
        settingsmenubutton.onClick.AddListener(() => UIManager.Instance.SettingsMenu());
        storemenubutton.onClick.AddListener(() => UIManager.Instance.StoreMenu());

        //FARM MENU BUTTONS
        bank.onClick.AddListener(() => GameManager.Instance.FarmManager.BuyBank());
        nuclear.onClick.AddListener(() => GameManager.Instance.FarmManager.BuyNuclear());
        gasoline.onClick.AddListener(() => GameManager.Instance.FarmManager.BuyGasoline());

        //PAY MENU BUTTONS
        rentbutton.onClick.AddListener(() => GameManager.Instance.PayManager.ResetRentPay());
        employeebutton.onClick.AddListener(() => GameManager.Instance.PayManager.ResetEmployeePay());
        taxbutton.onClick.AddListener(() => GameManager.Instance.PayManager.ResetTaxPay());
        billbutton.onClick.AddListener(()=>GameManager.Instance.PayManager.ResetBillPay());


        //CURRENCY MENU BUTTONS
        dollar.onClick.AddListener(()=>GameManager.Instance.CurrencyManager.CurrencyDolar());
        euro.onClick.AddListener(() => GameManager.Instance.CurrencyManager.CurrencyEuro());
        bitcoin.onClick.AddListener(() => GameManager.Instance.CurrencyManager.CurrencyBitcoin());


        //CURRENCY IMG BUTTONS
       
       

    }

    
 
}
