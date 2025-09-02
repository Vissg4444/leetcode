public class Solution
{
    public List<IList<int>> result = new List<IList<int>>();
    public List<IList<int>> CombinationSum(int[] nums, int target)
    {
        Iterate(nums, 0, target, new List<int>(), 0);
        return result;
    }

    public void Iterate(int[] nums, int indx, int target, List<int> cur, int sum)
    {
        if (sum == target)
        {
            result.Add(cur.ToList());
            return;
        }

        if (sum > target || indx >= nums.Length) return;

        cur.Add(nums[indx]);
        Iterate(nums, indx, target, cur, sum + nums[indx]);
        cur.Remove(cur.Last());
        Iterate(nums, indx + 1, target, cur, sum);
    }
}