public partial class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int left = 0;        
        int result = 0;
        Dictionary<char, int> keyValuePairs = new();
        for(int right=0; right <s.Length; right++)
        {
            if (keyValuePairs.ContainsKey(s[right]))
            {
                left = Math.Max(keyValuePairs[s[right]] + 1, left);
            }
            else
            {
                result = Math.Max(result, right - left + 1);
                keyValuePairs[s[right]] = right + 1;
            }
            right++;

        }
        return result;
    }
}