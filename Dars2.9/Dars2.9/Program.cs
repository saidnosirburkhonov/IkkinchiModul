using Dars2._9.Extensions;

namespace Dars2._9;

public class Program
{
    static void Main(string[] args)
    {
        int son = 5445;
        Console.WriteLine(son.GetSummOfDigits());

        string s = "salom2423";
        var res = s.RemoveDigits("g13");
        Console.WriteLine(res);
    }
}
