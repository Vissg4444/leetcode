public class Solution
{
   public int MinCostClimbingStairs(int[] cost)
   {
      int n = cost.Length;
      int[] steps = new int[n + 1];
      for (int i = 2; i <= n; i++)
      {
        steps[i] = Math.Min(steps[i - 1] + cost[i - 1], steps[i - 2] + cost[i - 2]);
      }
      return steps[n];
   }
}
