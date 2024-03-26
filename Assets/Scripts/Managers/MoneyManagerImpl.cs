public class MoneyManagerImpl : MoneyManager
{
    private Formatter _formatter;
    private NumberFormat _currentFormat;

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

    public Formatter GetFormatter()
    {
        return _formatter;
    }
}
