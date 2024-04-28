using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Paymanager : MonoBehaviour, Pay
{
    
    
    float billcooldown = 0, billupdatetimer = 1f, resetbill = 0;
    bool isresetbill;
    float _money;

    UIManager u�manager;
    

    private void Start()
    {
        u�manager = GameManager.Instance.UIManager;

    }

    IEnumerator Resetbill()
    {
        yield return new WaitForSeconds(.5f);
        isresetbill = false;
    }


    void Update()
    {
        

        _money = float.Parse(GameManager.Instance.MoneyManager.GetTotalMoney());

        //if (Time.time - billcooldown > billupdatetimer && !isresetbill)
        //{
        //    u�manager.taxpay.text = (0.01f + float.Parse(u�manager.taxpay.text)).ToString();
        //    u�manager.rentpay.text = (0.1f + float.Parse(u�manager.rentpay.text)).ToString();
        //    u�manager.employeepay.text = (0.01f + float.Parse(u�manager.employeepay.text)).ToString();
        //    u�manager.billpay.text = (0.01f + float.Parse(u�manager.billpay.text)).ToString();
           

        //    billcooldown = Time.time;
        //}



    }

   

    public void ResetTaxPay()
    {
        if (_money > float.Parse(u�manager.taxpay.text))
        {
            _money -= float.Parse(u�manager.taxpay.text);
            GameManager.Instance.UIManager.money = _money;
            isresetbill = true;
            u�manager.taxpay.text = resetbill.ToString();
            StartCoroutine(Resetbill());
        }
            
    }

    public void ResetRentPay()
    {
        if (_money > float.Parse(u�manager.rentpay.text))
        {
            _money -= float.Parse(u�manager.rentpay.text);
            GameManager.Instance.UIManager.money = _money;
            isresetbill = true;
            u�manager.rentpay.text = resetbill.ToString();
            StartCoroutine(Resetbill());
        }
            
    }

    public void ResetEmployeePay()
    {
        if (_money > float.Parse(u�manager.employeepay.text))
        {
            _money -= float.Parse(u�manager.employeepay.text);
            GameManager.Instance.UIManager.money = _money;
            isresetbill = true;
            u�manager.employeepay.text = resetbill.ToString();
            StartCoroutine(Resetbill());
        }
            
    }

    public void ResetBillPay()
    {
        if (_money > float.Parse(u�manager.billpay.text))
        {
            _money -= float.Parse(u�manager.billpay.text);
            GameManager.Instance.UIManager.money = _money;
            isresetbill = true;
            u�manager.billpay.text = resetbill.ToString();
            StartCoroutine(Resetbill());
        }
            
    }
}