public partial class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int[] arrayCopy =new int[nums1.Length];
        Array.Copy(nums1, arrayCopy, nums1.Length);
        int pointer1=0, pointer2=0;
        int i = 0;
        while (i < nums1.Length)
        {
            if (nums1[pointer1] < nums2[pointer2])
            {
                pointer2++;
            }
            else
            {
                arrayCopy[i] = nums2[pointer2];
                pointer1++;

            }
            i++;
        }
    }
}

