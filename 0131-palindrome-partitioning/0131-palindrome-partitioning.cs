public class Solution {
    List<IList<string>> result = new List<IList<string>>();
    public IList<IList<string>> Partition(string s) {
        Iterate(s, new List<string>(), 0, 1);
        return result;
    }
    static string reverseString(string s) {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
    public void Iterate(string s, List<string> curr, int l, int r)
    {
        if (r > s.Length) return;
        Iterate(s, new List<string>(curr), l, r + 1);
        string substr = s.Substring(l, r - l);
        if (substr == reverseString(substr))
        {
            curr.Add(substr);
            l = r + 1;
            Iterate(s, new List<string>(curr), r, r + 1);
            
        }
        if (l > s.Length) result.Add(curr);
    }
}
