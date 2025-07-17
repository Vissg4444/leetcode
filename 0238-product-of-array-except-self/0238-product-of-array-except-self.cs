public class Solution {
    public int[] ProductExceptSelf(int[] nums) 
    {
        int[] suffix = new int[nums.Length];
        int[] prefix = new int[nums.Length];

        suffix[0] = 1;
        prefix[^1] = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            suffix[i] = suffix[i - 1] * nums[i - 1];
        }
        for (int i = 2; i <= nums.Length; i++)
        {
            prefix[^i] = prefix[^(i - 1)] * nums[^(i - 1)];
        }

        List<int> result = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            result.Add(prefix[i] * suffix[i]);
        }
        return result.ToArray();
    }
}