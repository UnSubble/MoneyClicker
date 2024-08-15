public interface MoneyManager
{
    
    public NumberFormat GetCurrentFormat();
    
    public string GetFormattedMoney();

    public string GetTotalMoney();
    
    public void AddBuilding(Building building);

    public bool UpgradeBuilding(Building building);

    public Formatter GetFormatter();

    public void UpdateMoney();

    public float GetMoney();
   
}
