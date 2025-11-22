public partial class Solution
{
    public bool KLengthApart(int[] nums, int k)
    {
        int lastOneIndex = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            if (nums[i] == 1)
            {

                if (i != 0 && lastOneIndex < k)
                    return false;
                lastOneIndex = 0;
            }
            else
            {
                lastOneIndex++;
            }
        }
        return true;
    }
}