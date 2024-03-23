using System;

public class MoneyClickedEvent : Event
{
    private Type _textPopupType;
    private string _producedMoney;
    private NumberFormat _numberFormat;

    public MoneyClickedEvent(Type textPopupType, string producedMoney, NumberFormat numberFormat) 
    {
        _textPopupType = textPopupType;
        _producedMoney = producedMoney;
        _numberFormat = numberFormat;
    }

    public void Handle()
    {
        Pool pool = GameManager.Instance.Pool;     
        Formatter formatter = GameManager.Instance.Formatter;
        pool.Perform(_textPopupType, _producedMoney + " " + formatter.NumberFormatToStr(_numberFormat));
    }

    public bool HasEnded()
    {
        return true;
    }
}
