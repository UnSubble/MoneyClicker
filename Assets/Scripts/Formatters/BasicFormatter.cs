using System;

public class BasicFormatter : Formatter
{
    public NumberFormat Format(ref string money, NumberFormat numberFormat)
    {
        Objects.RequireNotNull(money);
        string[] splitted = money.Split('.');
        string target = splitted[0];

        if (target.Length > 3)
        {
            string decimalPart = target.Substring(target.Length - 3, 2);
            money = target.Substring(0, target.Length - 3) + "." + decimalPart;
            if (numberFormat != NumberFormat.OCTILLION)
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
}
