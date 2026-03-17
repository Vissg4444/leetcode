public class Solution {
    List<IList<int>> result = new List<IList<int>>();
    public IList<IList<int>> Permute(int[] nums) {
        Iterate(nums, new bool[nums.Length], new List<int>());
        return result;
        
    }
    public void Iterate(int[] nums, bool[] taken, List<int> curr)
    {
        if (curr.Count == nums.Length)
        {
            result.Add(new List<int>(curr));
            return;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if(!taken[i])
            {
                curr.Add(nums[i]);
                taken[i] = true;
                Iterate(nums, taken, curr);

                taken[i] = false;
                curr.RemoveAt(curr.Count - 1);
            }
        }
        return;
    }
}
