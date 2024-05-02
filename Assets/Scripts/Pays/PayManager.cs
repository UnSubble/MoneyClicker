using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Paymanager : MonoBehaviour, Pay
{
    
    
    float billcooldown = 0, billupdatetimer = 2f, resetbill = 0;
    bool isresetbill;
    

    
    FarmManager farmmanager; 
   
    

    private void Start()
    {
        
        farmmanager = GameManager.Instance.FarmManager;

    }

    IEnumerator Resetbill()
    {
        yield return new WaitForSeconds(.5f);
        isresetbill = false;
    }


    void Update()
    {


        AAmountPool.money = float.Parse(GameManager.Instance.MoneyManager.GetTotalMoney());

        

        UpdatePays();

    }

    void UpdatePays()
    {
        if (Time.time - billcooldown > billupdatetimer && !isresetbill)
        {
            UIManager.Instance.rentpay.text=(AAmountPool.bankcount+AAmountPool.nuclearcount+AAmountPool.gasolinecount+AAmountPool.rentpay).ToSafeString();

            //UIManager.Instance.taxpay.text =
            //    (farmmanager._bankcount*0.03f+farmmanager._nuclearcount*0.05f+farmmanager._oilcount*0.04f+ float.Parse(UIManager.Instance.taxpay.text)).ToString();

            //UIManager.Instance.employeepay.text =
            //    (farmmanager._bankcount*0.5f+farmmanager._oilcount*0.01+farmmanager._nuclearcount*0.02+ float.Parse(UIManager.Instance.employeepay.text)).ToString();

            billcooldown = Time.time;
        }
    }

   

    public void ResetTaxPay()
    {
        //if (_money > float.Parse(UIManager.Instance.taxpay.text))
        //{
        //    _money -= float.Parse(UIManager.Instance.taxpay.text);
        //    GameManager.Instance.UIManager.money = _money;
        //    isresetbill = true;
        //    UIManager.Instance.taxpay.text = resetbill.ToString();
        //    StartCoroutine(Resetbill());
        //}
            
    }

    public void ResetRentPay()
    {
        if (AAmountPool.money > AAmountPool.rentpay)
        {
            AAmountPool.money -= AAmountPool.rentpay;
            isresetbill = true;
            UIManager.Instance.rentpay.text = resetbill.ToString();
            StartCoroutine(Resetbill());
        }

    }

    public void ResetEmployeePay()
    {
        //if (_money > float.Parse(UIManager.Instance.employeepay.text))
        //{
        //    _money -= float.Parse(UIManager.Instance.employeepay.text);
        //    GameManager.Instance.UIManager.money = _money;
        //    isresetbill = true;
        //    UIManager.Instance.employeepay.text = resetbill.ToString();
        //    StartCoroutine(Resetbill());
        //}
            
    }

    public void ResetBillPay()
    {
        //if (_money > float.Parse(UIManager.Instance.billpay.text))
        //{
        //    _money -= float.Parse(UIManager.Instance.billpay.text);
        //    GameManager.Instance.UIManager.money = _money;
        //    isresetbill = true;
        //    UIManager.Instance.billpay.text = resetbill.ToString();
        //    StartCoroutine(Resetbill());
        //}
            
    }
}