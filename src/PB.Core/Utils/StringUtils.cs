namespace PB.Core.Utilsl;

public static class StringUtils
{
    public static string ApenasNumeros(this string str, string input)
    {
        return new string(input.Where(char.IsDigit).ToArray());
    }
}
