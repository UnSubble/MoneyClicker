using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractBuilding : MonoBehaviour, Building
{
    protected decimal _producedMoney;
    protected decimal _capacity;
    protected NumberFormat _currentFormat;

    protected void Update()
    {
        if (CheckFormatOverflow())
        {
            UpdateFormat();
        }
    }

    public NumberFormat GetFormat()
    {
        return 0;
    }

    public decimal GetMoney()
    {
        return 0;
    }

    public decimal GetNTimesUpgradeCost(int times)
    {
        return 0;
    }

    public bool HasNextLevel()
    {
        return false;
    }

    public bool Upgrade()
    {
        return false;
    }

    private bool CheckFormatOverflow()
    {
        return false;
    }

    private void UpdateFormat()
    {
       
    } 
}
