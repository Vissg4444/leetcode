public class Solution {
    private List<string> res = new List<string>();
    private Dictionary<char, string> digitToChar = new Dictionary<char, string> {
        {'2', "abc"}, {'3', "def"}, {'4', "ghi"}, {'5', "jkl"},
        {'6', "mno"}, {'7', "qprs"}, {'8', "tuv"}, {'9', "wxyz"}
    };
    public IList<string> LetterCombinations(string digits) {
        if (digits == String.Empty)
            return [];
        Iterate(digits, "", 0);
        return res;
    }
    public void Iterate(string digits, string curr, int indx)
    {
        if (curr.Length == digits.Length)
        {
            res.Add(curr);
            return;
        }
        string str = digitToChar[digits[indx]];
        for (int i = 0; i < str.Length; i++)
            Iterate(digits, curr + digitToChar[digits[indx]][i], indx + 1);
    }

}
