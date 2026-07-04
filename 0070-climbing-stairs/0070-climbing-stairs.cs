public class Solution
{
   public int ClimbStairs(int n)
   {
      if (n == 1) return 1;
      else if (n == 2) return 2;
      int[] array = new int[n];
      array[0] = 1;
      array[1] = 2;

      return ClimbStairsMemo(n, array);
   }
   public int ClimbStairsMemo(int n, int[] array)
   {
      if (array[n - 3] == 0)
      {
         array[n - 3] = ClimbStairsMemo(n - 2, array);
      }
      if (array[n - 2] == 0)
      {
         array[n - 2] = ClimbStairsMemo(n - 1, array);
      }

      array[n - 1] = array[n - 2] + array[n - 3];
      return array[n - 1];
   }

}

