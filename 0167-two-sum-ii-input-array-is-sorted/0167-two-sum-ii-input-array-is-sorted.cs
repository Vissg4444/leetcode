public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            int index = Array.IndexOf(nums, target - nums[i]);
            if (index != -1 & index != i)
            {
                int min_elem = Math.Min(index, i);
                int max_elem = Math.Max(index, i);
                return new int[] { min_elem + 1, max_elem + 1 };
            }
        }
        return new int[] {};
    }
}