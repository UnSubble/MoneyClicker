using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CurrencyManager : MonoBehaviour,ICurrency
{

    float currencycooldown = 0, currencyupdatetimer = 2f; bool isupdatecurrency;
    IEnumerator UpdateCurrency()
    {
        yield return new WaitForSeconds(.5f);
        isupdatecurrency = false;
    }
  
    public void CurrencyEuro()
    {
        if (AAmountPool.money > AAmountPool.euroinstant)
        {
            isupdatecurrency = true;
            AAmountPool.money -= AAmountPool.euroinstant;
            AAmountPool.euroamount += AAmountPool.euroinstant;
            UIManager.Instance.UpdateEuroCount();
            StartCoroutine(UpdateCurrency());
        }
    }

    public void CurrencyBitcoin()
    {
        if (AAmountPool.money > AAmountPool.bitcoininstant)
        {
            isupdatecurrency = true;
            AAmountPool.money -= AAmountPool.bitcoininstant;
            AAmountPool.bitcoinamount += AAmountPool.bitcoininstant;
            UIManager.Instance.UpdateBitcoinCount();
            StartCoroutine(UpdateCurrency());
        }
    }

    public void CurrencyDolar()
    {
        if(AAmountPool.money>AAmountPool.dollarinstant)
        {
            isupdatecurrency=true;
            AAmountPool.money -=AAmountPool.dollarinstant;
            AAmountPool.dolaramount += AAmountPool.dollarinstant;
            UIManager.Instance.UpdateDollarCount();
            StartCoroutine(UpdateCurrency());
        }
    }

   

    void Start()
    {
        
    }

    
    void Update()
    {
        if(Time.time-currencycooldown>currencyupdatetimer &&!isupdatecurrency)
        {
            UpdateDollar();
            UpdateBitcoin();
            UpdateEuro();
            currencycooldown = Time.time;
        }
    }

    

    public string UpdateDollar()
    {
        return UIManager.Instance.dollarinstant.text = (AAmountPool.dollarinstant +1).ToSafeString() ;
    }
    public string UpdateBitcoin()
    {
        return UIManager.Instance.bitcoininstant.text = (AAmountPool.bitcoininstant +2).ToSafeString() ;
    }

    public string UpdateEuro()
    {
        return UIManager.Instance.euroinstant.text = (AAmountPool.euroinstant +3).ToSafeString();
    }

    
}
