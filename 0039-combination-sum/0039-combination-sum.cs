public class Solution
{
    public List<IList<int>> result = new List<IList<int>>();
    public IList<IList<int>> CombinationSum(int[] nums, int target)
    {
        Iterate(nums, new List<int>(), 0, 0, target);
        return result;
    }
    public void Iterate(int[] nums, List<int> curr, int i, int sum, int target)
    {
        if (sum == target)
        {
            result.Add(new List<int>(curr));
            return;
        }

        if (sum > target || i >= nums.Length) return;

        curr.Add(nums[i]);
        Iterate(nums, curr, i, sum + nums[i], target);
        curr.Remove(curr.Last());
        Iterate(nums, curr, i + 1, sum, target);
    }
}