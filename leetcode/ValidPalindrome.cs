
using System.ComponentModel.Design;

public partial class Solution
{
    public bool IsPalindrome(string s)
    {
        var charArray=s.ToCharArray();
        int left = 0; int right = charArray.Length-1;
        while (left < right)
        {
            if (char.IsLetterOrDigit(charArray[left]))
            {
                if (char.IsLetterOrDigit(charArray[right]))
                {
                    if (char.ToLower(charArray[left])!= char.ToLower(charArray[right]))
                        return false;
                    else
                    {
                        right--;
                        left++;
                    }
                }
                else
                    right--;
            }
            else
                left++;
        }
        return true;
    }
}

