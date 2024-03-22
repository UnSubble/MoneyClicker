public interface Building
{

    public decimal GetMoney();

    public NumberFormat GetFormat();

    public bool HasNextLevel();

    public bool Upgrade();

    decimal GetNTimesUpgradeCost(int times);
}
