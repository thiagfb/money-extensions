namespace MoneyExtension;

public static class Money
{
    public static int ToCents(this decimal amount)
    {
        if (amount < 0)
        {
            return 0;
        }

        var text = amount
            .ToString("N2")
            .Replace(",", "")
            .Replace(".", "");

        if (String.IsNullOrEmpty(text))
            return 0;

        int.TryParse(text, out var result);

        return result;
    }
}
