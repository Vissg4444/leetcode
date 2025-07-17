
public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
    {
        var dic = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (dic.TryGetValue(num, out int val))
                dic[num]++;
            else
                dic[num] = 1;
        }

        var freq = new List<List<int>>();
        for (int i = 0; i < nums.Length + 1; i++)
            freq.Add(new List<int>());
        foreach (var pair in dic)
            freq[pair.Value].Add(pair.Key);

        List<int> result = new List<int>();
        for (int i = freq.Count - 1; k > 0; i--)
        {
            for(int j = 0; j < freq[i].Count & k > 0; j++)
            {
                result.Add(freq[i][j]);
                k--;
            }
        }

        return result.ToArray();
    }
}
