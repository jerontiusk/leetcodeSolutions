public partial class Solution
{
    public int GetNextNum(int num)
    {
        int totalSum = 0;
        while (num > 0)
        {
            int divisor = num % 10;
            num = num / 10;
            totalSum += divisor * divisor;
        }
        return totalSum;
    }
    public bool IsHappy(int n)
    {
        int slowRunner = n;
        int fastRunner = GetNextNum(n);
        while (slowRunner != fastRunner && fastRunner != 1)
        {
            slowRunner = GetNextNum(slowRunner);
            fastRunner = GetNextNum(GetNextNum(fastRunner));
        }
        return fastRunner == 1;
    }
}