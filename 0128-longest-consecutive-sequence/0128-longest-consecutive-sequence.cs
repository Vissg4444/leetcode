public class Solution {
    public int LongestConsecutive(int[] nums1) 
    { 
        if (nums1.Length == 0) return 0;
        var nums = new HashSet<int>(nums1);
        int longest = 0;
        foreach (int num in nums)
        {
            if (!nums.Contains(num + 1))
            {
                int curr = 1;
                while (nums.Contains(num - curr))
                {
                    curr++;
                }
                longest = Math.Max(longest, curr);
            }
        }
        return longest;
    }
}