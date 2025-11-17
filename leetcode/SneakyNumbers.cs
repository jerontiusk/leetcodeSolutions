public partial class Solution
{
    public int[] GetSneakyNumbers(int[] nums)
    {
        var result = new List<int>();
        var map = new HashSet<int>();
        foreach (int i in nums)
        {
            if(!map.TryGetValue(i,out int c))
            {
                map.Add(i);
            }
            else
            {
                result.Add(i);
            }
        }
        return result.ToArray();
    }
}
