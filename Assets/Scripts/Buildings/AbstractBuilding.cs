using UnityEngine;

public class AbstractBuilding : MonoBehaviour, Building
{
    protected decimal _producedMoney;
    protected decimal _capacity;
    protected NumberFormat _currentFormat;
    [SerializeField]
    protected int _maxLevel;
    protected int _currentLevel;

    protected void Update()
    {
        if (CheckFormatOverflow())
        {
            UpdateFormat();
        }
    }

    public NumberFormat GetFormat()
    {
        return _currentFormat;
    }

    public decimal GetMoney()
    {
        return _producedMoney;
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
        string[] splitted = _producedMoney.ToString().Split('.');
        return splitted[0].Length > 3;
    }

    private void UpdateFormat()
    {

    }

    public decimal GetCapacity()
    {
        return _capacity;
    }
}
