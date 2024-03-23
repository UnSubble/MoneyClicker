using System;

public class BasicFormatter : Formatter
{
    private string[] _numberFormatStrings;

    public BasicFormatter()
    {
        _numberFormatStrings = new string[] {"", "K", "M", "B", "T", "Q", "Sx", "Sp", "Oc"};
    }

    public NumberFormat Format(ref string money, NumberFormat numberFormat)
    {
        Objects.RequireNotNull(money);
        string[] splitted = money.Split('.');
        string target = splitted[0];

        if (target.Length > 3 && numberFormat != NumberFormat.OCTILLION)
        {
            string decimalPart = target.Substring(target.Length - 3, 2);
            money = target.Substring(0, target.Length - 3) + "." + decimalPart;
            numberFormat = numberFormat + 3;
        }

        return numberFormat;
    }

    public NumberFormat Format(ref decimal money, NumberFormat numberFormat)
    {
        string moneyStr = money.ToString();
        numberFormat = Format(ref moneyStr, numberFormat);
        money = Convert.ToDecimal(moneyStr);
        return numberFormat;
    }

    public string NumberFormatToStr(NumberFormat numberFormat)
    {
        return _numberFormatStrings[(int)numberFormat % 3];
    }
}
