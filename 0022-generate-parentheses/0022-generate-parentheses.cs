public class Solution {
    List<string> result = new List<string>(); 
    public IList<string> GenerateParenthesis(int n) {
        Iterate(n, 0, 0, "");
        return result;
    }
    public void Iterate(int n, int l, int r, string curr)
    {
        if (curr.Length == 2 * n)
        {
            result.Add(curr);
            return;
        }
        if (l < n)
        {
            Iterate(n, l + 1, r, curr + "(");
        }
        if (r < l)
        {
            Iterate(n, l, r + 1, curr + ")");
        }
    }
}
