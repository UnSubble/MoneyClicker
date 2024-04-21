using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class BillManager : MonoBehaviour, Bill
{
    TextMeshProUGUI electrickbill, firebill, waterbill, phonebill, internetbill;
    
    float billcooldown = 0, billupdatetimer = .5f, resetbill = 0;
    bool isresetbill;
    float _money;
    FarmManager _farmmanager;
    int _bankcount, _nuclearcount, _oilcount;

    private void Start()
    {
        electrickbill = GameObject.Find("ElectricBill").GetComponent<TextMeshProUGUI>();
        firebill = GameObject.Find("FireBill").GetComponent<TextMeshProUGUI>();
        phonebill = GameObject.Find("PhoneBill").GetComponent<TextMeshProUGUI>();
        waterbill = GameObject.Find("WaterBill").GetComponent<TextMeshProUGUI>();
        internetbill = GameObject.Find("InternetBill").GetComponent<TextMeshProUGUI>();
        _farmmanager = GameManager.Instance.FarmManager;

    }

    IEnumerator Resetbill()
    {
        yield return new WaitForSeconds(.5f);
        isresetbill = false;
    }


    void Update()
    {
        

        _money = GameManager.Instance.UIManager.money;
        _bankcount = _farmmanager._bankcount;
        _oilcount=_farmmanager._oilcount;
        _nuclearcount= _farmmanager._nuclearcount;

        if (Time.time - billcooldown > billupdatetimer && !isresetbill)
        {
            electrickbill.text = (0.01f + (_nuclearcount/100f) + float.Parse(electrickbill.text)).ToString();
            waterbill.text = (0.5f + float.Parse(waterbill.text)).ToString();
            internetbill.text = (0.01f + float.Parse(internetbill.text)).ToString();
            firebill.text = (0.01f + float.Parse(firebill.text)).ToString();
            phonebill.text = (0.01f + float.Parse(phonebill.text)).ToString();

            billcooldown = Time.time;
        }



    }

   

    public void ResetWaterBill()
    {
        if (_money > float.Parse(waterbill.text))
        {
            _money -= float.Parse(waterbill.text);
            GameManager.Instance.UIManager.money = _money;
            isresetbill = true;
            waterbill.text = resetbill.ToString();
            StartCoroutine(Resetbill());
        }
        
        

    }

    public void ResetPhoneBill()
    {
        if (_money > float.Parse(phonebill.text))
        {
            _money -= float.Parse(phonebill.text);
            GameManager.Instance.UIManager.money = _money;
            isresetbill = true;
            phonebill.text = resetbill.ToString();
            StartCoroutine(Resetbill());
        }
            
    }

    public void ResetElectrickBill()
    {
        if (_money > float.Parse(electrickbill.text))
        {
            _money -= float.Parse(electrickbill.text);
            GameManager.Instance.UIManager.money = _money;
            isresetbill = true;
            electrickbill.text = resetbill.ToString();
            StartCoroutine(Resetbill());
        }
            
    }

    public void ResetFireBill()
    {
        if (_money > float.Parse(firebill.text))
        {
            _money -= float.Parse(firebill.text);
            GameManager.Instance.UIManager.money = _money;
            isresetbill = true;
            firebill.text = resetbill.ToString();
            StartCoroutine(Resetbill());
        }
            
    }

    public void ResetInternetBill()
    {
        if (_money > float.Parse(internetbill.text))
        {
            _money -= float.Parse(internetbill.text);
            GameManager.Instance.UIManager.money = _money;
            isresetbill = true;
            internetbill.text = resetbill.ToString();
            StartCoroutine(Resetbill());
        }
            
    }
}