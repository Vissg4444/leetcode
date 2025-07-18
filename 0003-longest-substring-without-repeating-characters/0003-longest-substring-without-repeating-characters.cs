public class Solution {
    public int LengthOfLongestSubstring(string s)
    {
        if (s.Length == 0) return 0;
        int l = 0, r = 0, result = 0;
        string substr = "";
        for (;r < s.Length;)
        {
            while (substr.Contains(s[r]))
            {
                substr = substr.Remove(0, 1);
                l++;
            }
            substr += s[r];
            result = Math.Max(result, r - l + 1);
            r++;
        }
        return result;
    }
}