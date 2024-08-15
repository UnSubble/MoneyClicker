using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreManager : MonoBehaviour
{

    public void BuyAutoClick()
    {
        if (PoolManager.Instance.money >= PoolManager.Instance.autoclickfee)
        {
            PoolManager.Instance.money -=PoolManager.Instance.autoclickfee;
            PoolManager.Instance.autoclickcount++;
            PoolManager.Instance.autoclickfee += PoolManager.Instance.autoclickcount * 200;
        }
    }

    public void BuyClickCount()
    {
        if (PoolManager.Instance.money >= PoolManager.Instance.clickcountfee)
        {
            PoolManager.Instance.money -= PoolManager.Instance.clickcountfee;
            PoolManager.Instance.clickcount++;
            PoolManager.Instance.clickcountfee += PoolManager.Instance.clickcount * 200;
        }
    }
}
