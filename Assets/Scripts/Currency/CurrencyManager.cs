
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CurrencyManager : MonoBehaviour, ICurrency
{


    public void CurrencyDolar()
    {
        if (PoolManager.Instance.money >= PoolManager.Instance.dollarinstant && !ButtonManager.Instance.isclicked)
        {
            AudioManager.Instance.PlayCurrencySound();
            ButtonManager.Instance.isclicked = true;
            PoolManager.Instance.money -= PoolManager.Instance.dollarinstant;
            PoolManager.Instance.dollaramount++;
            StartCoroutine(ButtonManager.Instance.Clicked());
        }

    }
    public void CurrencyEuro()
    {
        if (PoolManager.Instance.money >= PoolManager.Instance.euroinstant && !ButtonManager.Instance.isclicked)
        {
            AudioManager.Instance.PlayCurrencySound();
            ButtonManager.Instance.isclicked = true;
            PoolManager.Instance.money -= PoolManager.Instance.euroinstant;
            PoolManager.Instance.euroamount++;
            StartCoroutine(ButtonManager.Instance.Clicked());

        }
    }

    public void CurrencyBitcoin()
    {
        if (PoolManager.Instance.money >= PoolManager.Instance.bitcoininstant && !ButtonManager.Instance.isclicked)
        {
            AudioManager.Instance.PlayCurrencySound();
            ButtonManager.Instance.isclicked = true;
            PoolManager.Instance.money -= PoolManager.Instance.bitcoininstant;
            PoolManager.Instance.bitcoinamount++;
            StartCoroutine(ButtonManager.Instance.Clicked());
        }
    }

    void Start() => StartCoroutine(UpdateCurrency());

    IEnumerator UpdateCurrency()
    {
        while (true)
        {
            PoolManager.Instance.dollarinstant++;
            PoolManager.Instance.euroinstant++;
            PoolManager.Instance.bitcoininstant += 5;
            yield return new WaitForSeconds(3f);
        }
    }

    




}
