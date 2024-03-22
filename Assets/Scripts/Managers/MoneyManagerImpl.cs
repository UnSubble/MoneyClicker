public class MoneyManagerImpl : MoneyManager
{
    private Formatter _formatter;

    public MoneyManagerImpl(Formatter formatter)
    {
        _formatter = formatter;
    }

    public void AddBuilding(Building building)
    {
        
    }

    public NumberFormat GetCurrentFormat()
    {
        return 0;
    }

    public string GetFormattedMoney()
    {
        return null;
    }

    public decimal GetMoney()
    {
        return 0;
    }

    public bool UpgradeBuilding(Building building)
    {
        return false;
    }
}
