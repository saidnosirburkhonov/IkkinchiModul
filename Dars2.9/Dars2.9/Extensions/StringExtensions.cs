namespace Dars2._9.Extensions;

public static class StringExtensions
{
    public static string RemoveDigits(this string s, string a)
    {
        for(var i = 0; i < s.Length; i++)
        {
            if (char.IsDigit(s[i]))
            {
                s = s.Remove(i, 1);
                --i;
            }
        }
        return s + a;
    }
}
