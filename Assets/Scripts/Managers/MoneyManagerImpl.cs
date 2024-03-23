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

    public string GetTotalMoney()
    {
        return null;
    }

    public bool UpgradeBuilding(Building building)
    {
        return false;
    }
    public string GetFormattedMoney()
    {
        return null;
    }

}
