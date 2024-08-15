using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmManager : MonoBehaviour, Farm
{


    public void BuyBank()
    {
        if (PoolManager.Instance.money >= PoolManager.Instance.bankfee && !ButtonManager.Instance.isclicked)
        {
            AudioManager.Instance.PlayCurrencySound();
            ButtonManager.Instance.isclicked = true;
            PoolManager.Instance.money -= PoolManager.Instance.bankfee;
            PoolManager.Instance.bankcount++;
            PoolManager.Instance.bankfee += PoolManager.Instance.bankcount * 100;
            StartCoroutine(ButtonManager.Instance.Clicked());
        }
    }

    public void BuyNuclear()
    {
        if (PoolManager.Instance.money >= PoolManager.Instance.nuclearfee && !ButtonManager.Instance.isclicked)
        {
            AudioManager.Instance.PlayCurrencySound();
            ButtonManager.Instance.isclicked = true;
            PoolManager.Instance.money -= PoolManager.Instance.nuclearfee;
            PoolManager.Instance.nuclearcount++;
            PoolManager.Instance.nuclearfee += PoolManager.Instance.nuclearcount * 100;
            StartCoroutine(ButtonManager.Instance.Clicked());
        }

    }

    public void BuyGasoline()
    {
        if (PoolManager.Instance.money >= PoolManager.Instance.gasolinefee && !ButtonManager.Instance.isclicked)
        {
            AudioManager.Instance.PlayCurrencySound();
            ButtonManager.Instance.isclicked = true;
            PoolManager.Instance.money -= PoolManager.Instance.gasolinefee;
            PoolManager.Instance.gasolinecount++;
            PoolManager.Instance.gasolinefee += PoolManager.Instance.gasolinecount * 100;
            StartCoroutine(ButtonManager.Instance.Clicked());
        }
    }

    void Update()
    {
        if (PoolManager.Instance.rentpay >= 1000f && PoolManager.Instance.bankcount>0)
        {
            PoolManager.Instance.bankcount--;
            StartCoroutine(DestroyFarm());
        }
        else if (PoolManager.Instance.rentpay >= 2000f && PoolManager.Instance.nuclearcount > 0)
        {
            PoolManager.Instance.nuclearcount--;
            StartCoroutine(DestroyFarm());
        }
        else if (PoolManager.Instance.rentpay >= 3000f && PoolManager.Instance.gasolinecount > 0)
        {
            PoolManager.Instance.gasolinecount--;
            StartCoroutine(DestroyFarm());
        }


        if (PoolManager.Instance.taxpay >= 3000)
        {

        }
        else if (PoolManager.Instance.taxpay >= 4000)
        {


        }
        else if (PoolManager.Instance.taxpay >= 5000)
        {

        }
    }

    IEnumerator DestroyFarm()
    {
        yield return new WaitForSeconds(10f);
    }
}
