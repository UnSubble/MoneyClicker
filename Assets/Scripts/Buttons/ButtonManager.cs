using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class ButtonManager : MonoBehaviour, IButton
{

   
    private Button  _nuclearbutton,rentbutton,employeebutton,taxbutton,billbutton;
    FarmManager farmmanager;
    UIManager u�manager;
    public Toggle farmbutton, currencybutton;

    private void Awake()
    {
        
        
    }

    void Start()
    {
        farmmanager = GameManager.Instance.FarmManager;
        u�manager = GameManager.Instance.UIManager;

        farmbutton = GameObject.Find("FarmButton").GetComponent<Toggle>();
        currencybutton = GameObject.Find("CurrencyButton").GetComponent<Toggle>();
        _nuclearbutton = GameObject.Find("Nuclear").GetComponent<Button>();



        farmbutton.onValueChanged.AddListener(u�manager.FarmMenu);
        currencybutton.onValueChanged.AddListener(u�manager.CurrencyMenu);

    }


    void Update()
    {
        
        
        //_nuclearbutton.onClick.AddListener(() => farmmanager.NuclearCount());
        
    }

    public void Rent()
    {
        GameManager.Instance.PayManager.ResetRentPay();
    }

    public void Employee()
    {
        GameManager.Instance.PayManager.ResetEmployeePay();
    }

    public void Tax()
    {
        GameManager.Instance.PayManager.ResetTaxPay();
    }

    public void Bill()
    {
        GameManager.Instance.PayManager.ResetBillPay();
    }
}
