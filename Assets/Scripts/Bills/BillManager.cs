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
    float _electrick, _fire, _phone, _water, _internet;
    float billcooldown = 0, billupdatetimer = .5f, resetbill = 0;
    bool isresetbill;
    float checkmoney;

    private void Start()
    {
        electrickbill = GameObject.Find("ElectricBill").GetComponent<TextMeshProUGUI>();
        firebill = GameObject.Find("FireBill").GetComponent<TextMeshProUGUI>();
        phonebill = GameObject.Find("PhoneBill").GetComponent<TextMeshProUGUI>();
        waterbill = GameObject.Find("WaterBill").GetComponent<TextMeshProUGUI>();
        internetbill = GameObject.Find("InternetBill").GetComponent<TextMeshProUGUI>();
        

    }

    IEnumerator Resetbill()
    {
        yield return new WaitForSeconds(.5f);
        isresetbill = false;
    }


    void Update()
    {
        if (Time.time - billcooldown > billupdatetimer && !isresetbill)
        {
            electrickbill.text = (0.01f + float.Parse(electrickbill.text)).ToString();
            waterbill.text = (0.01f + float.Parse(waterbill.text)).ToString();
            internetbill.text = (0.01f + float.Parse(internetbill.text)).ToString();
            firebill.text = (0.01f + float.Parse(firebill.text)).ToString();
            phonebill.text = (0.01f + float.Parse(phonebill.text)).ToString();

            billcooldown = Time.time;
        }
        checkmoney = GameManager.Instance.UIManager.money;
        _water = float.Parse(waterbill.text);
        


    }

    public void ResetWaterBill()
    {
        if (checkmoney > _water)
        {
            isresetbill = true;
            waterbill.text = resetbill.ToString();
            StartCoroutine(Resetbill());
        }
        else
            Debug.Log("dýd not payed");
        

    }

    public void ResetPhoneBill()
    {
        isresetbill = true;
        phonebill.text = resetbill.ToString();
        StartCoroutine(Resetbill());
    }

    public void ResetElectrickBill()
    {
        isresetbill = true;
        electrickbill.text = resetbill.ToString();
        StartCoroutine(Resetbill());
    }

    public void ResetFireBill()
    {
        isresetbill = true;
        firebill.text = resetbill.ToString();
        StartCoroutine(Resetbill());
    }

    public void ResetInternetBill()
    {
        isresetbill = true;
        internetbill.text = resetbill.ToString();
        StartCoroutine(Resetbill());
    }
}