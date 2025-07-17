public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        var result = new List<IList<int>>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0) break;
            if (i > 0 && nums[i - 1] == nums[i]) continue;
            int l = i + 1, r = nums.Length - 1;
            while (l < r)
            {
                int target = nums[i] + nums[l] + nums[r];
                if (target > 0)
                    r--;
                else if (target < 0)
                    l++;
                else
                {
                    result.Add(new List<int> { nums[i], nums[l], nums[r] });
                    l++;
                    r--;
                    while (l < r && nums[l] == nums[l - 1])
                        l++;
                }
            }

        }
        return result;

    }
}
