public class Solution {
    public bool IsValid(string s)
    {
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
            if (stack.Any())
            {
                if (closing.Contains(c))
                {
                    if (stack.Peek() == dic[c])
                    {
                        stack.Pop();
                        continue;
                    }
                    else return false;
                }
                
            }
            stack.Push(c);
        }
        return stack.Any() ? false : true;
    }
}
