public class Solution {
    public bool CheckInclusion(string s1, string s2)
    {
        if (s1.Length > s2.Length) return false;    
        var d1 = new Dictionary<char, int>();
        var d2 = new Dictionary<char, int>();

        foreach (char c in s1)
        {
            d1[c] = d1.GetValueOrDefault(c, 0) + 1;
        }
        foreach (char c in s2)
        {
            d1[c] = d1.GetValueOrDefault(c, 0);
            d2[c] = 0;
        }

        int l = 0, r = 0;
        while (r < s2.Length)
        {
            while (r - l < s1.Length)
            {
                d2[s2[r]] = d2.GetValueOrDefault(s2[r], 0) + 1;
                r++;
            }
            if (d1.Count == d2.Count && !d1.Except(d2).Any()) return true;
            d2[s2[l++]]--;
        }
        return false;
    }
}
