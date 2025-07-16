public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> dic = new Dictionary<int,int>();
        
        for (int i = 0; i < nums.Length; i++)
        {
            int seeking = target - nums[i];
            if (dic.ContainsKey(seeking))
            {
                return new int[] {dic[seeking], i};
            }
            else if (!dic.ContainsKey(nums[i]))
            {
                dic.Add(nums[i],i);
            }

        }
        return new int[] {};
        
    }
}
