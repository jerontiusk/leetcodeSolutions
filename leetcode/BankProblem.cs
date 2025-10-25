public partial class Solution
{
    public int TotalMoney(int n)
    {
        if (n == 0) return 0;
        int monday = 1;
        int total = 1;
        while (n >= 0)
        {
            for (int i = 1; i < Math.Min(n, 7); i++)
            {
                total += monday + i;
            }
            n = n - 7;
            monday++;
        }
        return total;
    }
}
