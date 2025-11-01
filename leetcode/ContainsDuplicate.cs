public partial class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        var keyHashSet = new HashSet<int>();
        for (int x = 0; x < nums.Length; x++)
        {
            if (keyHashSet.Contains(nums[x])) return true;
            else
            {
                keyHashSet.Add(nums[x]);
                if (keyHashSet.Count > k)
                {

                    keyHashSet.Remove(nums[x - k]);
                }
            }
        }
        return false;
    }

}
