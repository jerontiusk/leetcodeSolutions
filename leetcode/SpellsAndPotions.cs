public partial class Solution
{
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
    {
        int[] SuccessfulPairs = new int[spells.Length];
        Array.Sort(potions);
        for (int i = 0; i < spells.Length; i++)
        {
            int spell = spells[i];
            int mivalue = (int)Math.Ceiling((1.0 * success) / spell);
            if (mivalue > potions[potions.Length - 1])
            {
                SuccessfulPairs[i] = 0;
                continue;
            }
            int val = potions.Length - BinarySearch(potions, mivalue);
            SuccessfulPairs[i] = val;

        }
        return SuccessfulPairs;
    }
    private int BinarySearch(int[] values, int target)
    {
        int lo = 0;
        int hi = values.Length;
        
        while (lo < hi)
        {
            int mid = lo + (hi - lo) / 2;
            if (values[mid] < target)
            {
                lo = mid + 1;
            }
            else
            {
                hi = mid;
            }
        }

        return lo;
    }
}

