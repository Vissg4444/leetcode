public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        int l = 0, r = nums.Length - 1;

        for(; l < r; )
        {
            if (nums[l] + nums[r] > target)
                r--;
            else if (nums[l] + nums[r] < target)
                l++;
            else
                return new int[] {l + 1, r + 1};
        }
        return new int[0];
    }
}