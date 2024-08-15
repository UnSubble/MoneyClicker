using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class MoneyManagerImpl : MonoBehaviour, MoneyManager
{
    private Formatter _formatter;
    private NumberFormat _currentFormat;

    private void Start()
    {
        StartCoroutine(Demo());
    }
    IEnumerator Demo()
    {
        while (true)
        {
            PoolManager.Instance.money += PoolManager.Instance.autoclickcount + PoolManager.Instance.bankcount * 10 +
                                          PoolManager.Instance.nuclearcount * 15 + PoolManager.Instance.gasolinecount * 20;
            yield return new WaitForSeconds(1f);
        }
    }
    public void UpdateMoney()
    {
        PoolManager.Instance.money += PoolManager.Instance.clickcount;
        AudioManager.Instance.PlayCoinSound();
    }



    //public MoneyManagerImpl()
    //{
    //    _service = GameManager.Instance.Service;
    //    _currentFormat = _service.getNumberFormat();
    //}

    public MoneyManagerImpl(Formatter formatter)
    {
        _formatter = formatter;
    }

    public void AddBuilding(Building building)
    {

    }

    public NumberFormat GetCurrentFormat()
    {
        return _currentFormat;
    }

    public string GetTotalMoney()
    {
        
        return PoolManager.Instance.money.ToString();

    }

    public float GetMoney()
    {
        return PoolManager.Instance.money;
    }

    public bool UpgradeBuilding(Building building)
    {
        return false;
    }
    public string GetFormattedMoney()
    {
        return "null";
    }

    public Formatter GetFormatter()
    {
        return _formatter;
    }


}
