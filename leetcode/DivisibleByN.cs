namespace leetcode
{
    public partial class Solution
    {
        public int MinSubarray(int[] nums, int p)
        {
            int n = nums.Length;
            int totalSum = 0;

            // Step 1: Calculate total sum and target remainder
            foreach (int num in nums)
            {
                totalSum = (totalSum + num) % p;
            }

            int target = totalSum % p;
            if (target == 0)
            {
                return 0; // The array is already divisible by p
            }

            // Step 2: Use a dictionary to track prefix sum mod p
            Dictionary<int, int> modMap = new Dictionary<int, int>();
            modMap[0] = -1; // To handle the case where the whole prefix is the answer
            int currentSum = 0;
            int minLen = n;

            // Step 3: Iterate over the array
            for (int i = 0; i < n; ++i)
            {
                currentSum = (currentSum + nums[i]) % p;

                // Calculate what we need to remove
                int needed = (currentSum - target + p) % p;

                // If we have seen the needed remainder, we can consider this subarray
                if (modMap.ContainsKey(needed))
                {
                    minLen = Math.Min(minLen, i - modMap[needed]);
                }

                // Store the current remainder and index
                modMap[currentSum] = i;
            }

            // Step 4: Return result
            return minLen == n ? -1 : minLen;
        }
    }
}
