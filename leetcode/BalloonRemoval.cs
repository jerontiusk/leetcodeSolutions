
public partial class Solution
{
    public int MinCost(string colors, int[] neededTime)
    {
        int left = 0;
        int right = 0;
        int totalTime = 0;
        while (left < neededTime.Length && right < neededTime.Length)
        {
            int currentTotal = 0;
            int currentMax = 0;
            while (right < neededTime.Length && colors[left] == colors[right])
            {
                currentTotal += neededTime[right];
                currentMax = Math.Max(neededTime[right], currentMax);
                right++;
            }
            left = right;
            totalTime += currentTotal - currentMax;
        }
        return totalTime;
    }
}

