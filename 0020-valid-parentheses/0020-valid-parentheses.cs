public class Solution {
    public bool IsValid(string s)
    {
        if (s.Length % 2 != 0) return false;
        if (s.Length == 0) return true;
        var dic = new Dictionary<char, char>()
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };
        string closing = ")]}";
        var stack = new Stack<char>();
        foreach (char c in s)
        {
            if(c=='{' || c == '[' || c == '(')
                stack.Push(c);
            else 
            {
                if(stack.Count == 0 )
                    return false;
                if (stack.Peek() == dic[c])
                {
                    stack.Pop();
                    continue;
                }
                else return false;
            }
        }
        return stack.Any() ? false : true;
    }
}
