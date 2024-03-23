public interface Building
{

    public decimal GetMoney();

    public decimal GetCapacity();

    public NumberFormat GetFormat();

    public bool HasNextLevel();

    public bool Upgrade();
    
    public decimal GetNTimesUpgradeCost(int times);

}
