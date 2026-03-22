public class Solution {
    List<IList<int>> set = new List<IList<int>>();
    public List<IList<int>> SubsetsWithDup(int[] nums) {
        Array.Sort(nums);
        Iterate(nums, new List<int>(), 0);
        return set;
    }
    public void Iterate(int[] nums, List<int> curr, int start)
    {
        set.Add(new List<int>(curr));
        for (int i = start; i < nums.Length; i++)
        {
                if (i > start && nums[i] == nums[i - 1]) continue;
                curr.Add(nums[i]);
                Iterate(nums, curr, i + 1);
                curr.RemoveAt(curr.Count - 1);
        }
        return;
    }
}
