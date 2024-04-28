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

    UIManager uımanager;
    

    private void Start()
    {
        uımanager = GameManager.Instance.UIManager;

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
        //    uımanager.taxpay.text = (0.01f + float.Parse(uımanager.taxpay.text)).ToString();
        //    uımanager.rentpay.text = (0.1f + float.Parse(uımanager.rentpay.text)).ToString();
        //    uımanager.employeepay.text = (0.01f + float.Parse(uımanager.employeepay.text)).ToString();
        //    uımanager.billpay.text = (0.01f + float.Parse(uımanager.billpay.text)).ToString();
           

        //    billcooldown = Time.time;
        //}



    }

   

    public void ResetTaxPay()
    {
        if (_money > float.Parse(uımanager.taxpay.text))
        {
            _money -= float.Parse(uımanager.taxpay.text);
            GameManager.Instance.UIManager.money = _money;
            isresetbill = true;
            uımanager.taxpay.text = resetbill.ToString();
            StartCoroutine(Resetbill());
        }
            
    }

    public void ResetRentPay()
    {
        if (_money > float.Parse(uımanager.rentpay.text))
        {
            _money -= float.Parse(uımanager.rentpay.text);
            GameManager.Instance.UIManager.money = _money;
            isresetbill = true;
            uımanager.rentpay.text = resetbill.ToString();
            StartCoroutine(Resetbill());
        }
            
    }

    public void ResetEmployeePay()
    {
        if (_money > float.Parse(uımanager.employeepay.text))
        {
            _money -= float.Parse(uımanager.employeepay.text);
            GameManager.Instance.UIManager.money = _money;
            isresetbill = true;
            uımanager.employeepay.text = resetbill.ToString();
            StartCoroutine(Resetbill());
        }
            
    }

    public void ResetBillPay()
    {
        if (_money > float.Parse(uımanager.billpay.text))
        {
            _money -= float.Parse(uımanager.billpay.text);
            GameManager.Instance.UIManager.money = _money;
            isresetbill = true;
            uımanager.billpay.text = resetbill.ToString();
            StartCoroutine(Resetbill());
        }
            
    }
}