namespace Dars2._9.Extensions;

public static  class IntExtensions
{
    public static int GetSummOfDigits(this int num)
    {
        int sum = 0;
        while (true)
        {
            sum += num % 10;
            num /= 10;
            if (num == 0) break;
        }
        return sum;
    }
}
