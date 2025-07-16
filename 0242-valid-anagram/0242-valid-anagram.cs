public class Solution {
    public bool IsAnagram(string s, string t)
    {
        if(s.Length != t.Length) return false;
        char[] s_arr = s.ToCharArray();
        Array.Sort(s_arr);
        string s_sorted = new string(s_arr);

        char[] t_arr = t.ToCharArray();
        Array.Sort(t_arr);
        string t_sorted = new string(t_arr);

        if (s_sorted == t_sorted) return true;
        else return false;
    }
}
