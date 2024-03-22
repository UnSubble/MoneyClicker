public interface MoneyManager
{
    
    public NumberFormat GetCurrentFormat();
    
    public string GetFormattedMoney();
    
    public decimal GetMoney();
    
    public void AddBuilding(Building building);

    public bool UpgradeBuilding(Building building);
}
