public class Solution {
    public int CharacterReplacement(string s, int k)
    {
        int l = 0, r = 0, result = 0;
        var dic = new Dictionary<char, int>();

        while (r < s.Length)
        {      
            dic.TryGetValue(s[r], out int count);
            dic[s[r]] = count + 1;
            r++;

            while (dic.Values.Sum() - dic.Values.Max() > k)
            {
                dic[s[l]]--;
                l++;
            }
            result = Math.Max(result, r - l);
        }
        return result;
    }
}
