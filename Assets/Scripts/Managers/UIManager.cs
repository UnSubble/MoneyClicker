using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private MoneyManager _moneyManager; ButtonManager buttonmanager;

    [SerializeField] public
    TextMeshProUGUI moneytext,bankcount,nuclearcount,oilcount,bankfee,oilfee,nuclearfee,taxpay,billpay,employeepay,rentpay;
    
    
    public float money = 0;


   
    Transform farmmenu,currencymenu;


    public static UIManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
       

    }

    void Start()
    {
        //StartCoroutine(CheckMoney());
        _moneyManager = GameManager.Instance.MoneyManager;
        buttonmanager = GameManager.Instance.ButtonManager;

        moneytext = GameObject.Find("TotalMoney").GetComponent<TextMeshProUGUI>();
        oilcount = GameObject.Find("OilCount").GetComponent<TextMeshProUGUI>();
        bankcount = GameObject.Find("BankCount").GetComponent<TextMeshProUGUI>();
        nuclearcount = GameObject.Find("NuclearCount").GetComponent<TextMeshProUGUI>();
        bankfee= GameObject.Find("BankFee").GetComponent<TextMeshProUGUI>();
        oilfee = GameObject.Find("OilFee").GetComponent<TextMeshProUGUI>();
        nuclearfee = GameObject.Find("NuclearFee").GetComponent<TextMeshProUGUI>();

        //PAYS TEXT
        taxpay = GameObject.Find("TaxExpensesTxt").GetComponent<TextMeshProUGUI>();
        rentpay= GameObject.Find("RentExpensesTxt").GetComponent<TextMeshProUGUI>();
        employeepay= GameObject.Find("EmployeeExpensesTxt").GetComponent<TextMeshProUGUI>();
        billpay= GameObject.Find("BillExpensesTxt").GetComponent<TextMeshProUGUI>();



        farmmenu = GameObject.Find("FarmMenu").GetComponent<Transform>();
        currencymenu= GameObject.Find("CurrencyMenu").GetComponent<Transform>();
        

    }
    public void FarmMenu(bool on)
    {

        if (on)
        {
            farmmenu.position = new Vector2(0, 0);
            buttonmanager.currencybutton.isOn = false;
            
        }
        else farmmenu.position = new Vector2(0, -5);


    }

    public void CurrencyMenu(bool on)
    {
        if (on)
        {
            currencymenu.position = new Vector2(0, 0);
            buttonmanager.farmbutton.isOn = false;

        }
        else currencymenu.position = new Vector2(0, -5);
    }



    void Update()
    {
        moneytext.text = _moneyManager.GetTotalMoney();
        
    }

    //IEnumerator CheckMoney()
    //{
    //    while (true)
    //    {
    //        yield return new WaitForSeconds(GameManager.Instance.UICheckMoneyTime);
    //        _textMeshProUGUI.text = _moneyManager.GetFormattedMoney();

    //    }
    //}


    public void UpdateMoney() => money += 1f;




    



}
