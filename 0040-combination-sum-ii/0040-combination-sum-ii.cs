public class Solution
{
    List<IList<int>> result = new List<IList<int>>();
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        Array.Sort(candidates);
        Iterate(candidates, target, new List<int>(), 0, 0);

        return result;
    }
    public void Iterate(int[] candidates, int target, List<int> curr, int sum, int indx)
    {
        if (sum == target)
        {
            result.Add(new List<int>(curr));
            return;
        }

        if (sum > target || indx == candidates.Length) return;

        curr.Add(candidates[indx]);
        Iterate(candidates, target, curr, sum + candidates[indx], indx + 1);
        curr.RemoveAt(curr.Count - 1);

        while (indx + 1 < candidates.Length && candidates[indx] == candidates[indx + 1]) {
            indx++;
        }

        Iterate(candidates, target, curr, sum, indx + 1);
    }
}