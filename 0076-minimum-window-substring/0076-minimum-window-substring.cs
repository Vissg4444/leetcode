public class Solution {
    public string MinWindow(string s, string t)
    {

        string result = "";
        if (s.Length < t.Length) return result;
        if (t == "") return result;

        int reslen = int.MaxValue;
        int[] res = { -1, -1 }; 
        
        var dic_t = new Dictionary<char, int>();
        var dic_s = new Dictionary<char, int>();
        foreach (char c in t)
            dic_t[c] = dic_t.GetValueOrDefault(c, 0) + 1;

        int l = 0, r = 0, have = 0, need = dic_t.Count;

        for (; r < s.Length; r++)
        {
            char c = s[r];

            dic_s[c] = dic_s.GetValueOrDefault(c, 0) + 1;

            if (dic_t.ContainsKey(c) && dic_t[c] == dic_s[c])
                have++;

            while (have == need)
            {
                if (r - l + 1 < reslen)
                {
                    reslen = r - l + 1;
                    res[0] = l;
                    res[1] = r;
                }
                char left = s[l];

                dic_s[left]--;
                if (dic_t.ContainsKey(left) && dic_s[left] < dic_t[left])
                    have--;
                l++;
            }
        
        }
        return reslen == int.MaxValue ? "" : s.Substring(res[0], reslen);
    }
}
