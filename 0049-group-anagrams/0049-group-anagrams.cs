public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var dic = new Dictionary<string, IList<string>>();

        foreach (string str in strs)
        {
            int[] count = new int[26];
            foreach (char c in str)
            {
                count[c - 'a']++;
            }
            string key = string.Join(",",count);
            if (!dic.ContainsKey(key))
            {
                
                dic[key] = new List<string>();
            }
            dic[key].Add(str);
        }
        return new List<IList<string>>(dic.Values);
    }
}