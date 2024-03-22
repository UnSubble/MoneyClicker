public interface Formatter
{
    public NumberFormat Format(ref string money, NumberFormat numberFormat);

    public NumberFormat Format(ref decimal money, NumberFormat numberFormat);
}
