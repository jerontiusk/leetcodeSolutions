public partial class Solution
{
    public int MinimumOperations(int[] nums)
    {
        int operationsCount = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            var number = nums[i] ;
            operationsCount += Math.Min(number % 3, 3 - number % 3);

        }
        return operationsCount;
    }
}