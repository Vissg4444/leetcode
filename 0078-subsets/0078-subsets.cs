public class Solution
{
    List<IList<int>> result = new List<IList<int>>();
    public IList<IList<int>> Subsets(int[] nums)
    {
        
        Iterate(new List<int>(), 0, nums.Length, nums);
        return result;
    }

    public void Iterate(List<int> cur, int indxCur, int indxMax, int[] nums)
    {
        for(int i = indxCur; i < indxMax; i++)
        {
            Iterate(new List<int>(cur), i + 1, indxMax, nums);
            cur.Add(nums[i]);
        }
        result.Add(cur);
    }
}