namespace leetcode
{
    public partial class Solution
    {
        public int MinOperations(int[] nums, int k)
        {
            var sum = nums.Sum(x => x);
            return sum % k;
        }
    }
}
