using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Paymanager : MonoBehaviour, Pay
{

    void Start()
    {
        StartCoroutine(UpdatePays());
    }


    IEnumerator UpdatePays()
    {
        while (true)
        {
            PoolManager.Instance.taxpay += PoolManager.Instance.bankcount * 2f + PoolManager.Instance.gasolinecount * 5f + PoolManager.Instance.nuclearcount * 4f;
            PoolManager.Instance.rentpay += PoolManager.Instance.bankcount + PoolManager.Instance.gasolinecount + PoolManager.Instance.nuclearcount;
            PoolManager.Instance.employeepay += PoolManager.Instance.bankcount * 6f + PoolManager.Instance.gasolinecount * 2f + PoolManager.Instance.nuclearcount * 2f;
            PoolManager.Instance.billpay += PoolManager.Instance.bankcount * 3f + PoolManager.Instance.gasolinecount * 4f + PoolManager.Instance.nuclearcount * 3f;
            yield return new WaitForSeconds(2f);
        }
    }



    public void ResetTaxPay()
    {
        if (PoolManager.Instance.money >= PoolManager.Instance.taxpay && !ButtonManager.Instance.isclicked)
        {
            AudioManager.Instance.PlayPaymentSound();
            ButtonManager.Instance.isclicked = true;
            PoolManager.Instance.money -= PoolManager.Instance.taxpay;
            PoolManager.Instance.taxpay = 0;
            StartCoroutine(ButtonManager.Instance.Clicked());
        }

    }

    public void ResetRentPay()
    {
        if (PoolManager.Instance.money >= PoolManager.Instance.rentpay && !ButtonManager.Instance.isclicked)
        {
            AudioManager.Instance.PlayPaymentSound();
            ButtonManager.Instance.isclicked = true;
            PoolManager.Instance.money -= PoolManager.Instance.rentpay;
            PoolManager.Instance.rentpay = 0;
            StartCoroutine(ButtonManager.Instance.Clicked());
        }

    }

    public void ResetEmployeePay()
    {
        if (PoolManager.Instance.money >= PoolManager.Instance.employeepay && !ButtonManager.Instance.isclicked)
        {
            AudioManager.Instance.PlayPaymentSound();
            ButtonManager.Instance.isclicked = true;
            PoolManager.Instance.money -= PoolManager.Instance.employeepay;
            PoolManager.Instance.employeepay = 0;
            StartCoroutine(ButtonManager.Instance.Clicked());
        }

    }

    public void ResetBillPay()
    {
        if (PoolManager.Instance.money >= PoolManager.Instance.billpay && !ButtonManager.Instance.isclicked)
        {
            AudioManager.Instance.PlayPaymentSound();
            ButtonManager.Instance.isclicked = true;
            PoolManager.Instance.money -= PoolManager.Instance.billpay;
            PoolManager.Instance.billpay = 0;
            StartCoroutine(ButtonManager.Instance.Clicked());
        }

    }
}