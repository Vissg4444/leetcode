public class Solution {
    public int expression(int num1, int num2, string oper)
    {
        return oper switch
        {
            "+" => num1 + num2,
            "-" => num1 - num2,
            "*" => num1* num2,
                "/" => num1 / num2,
            _ => 0
        };
}
public int EvalRPN(string[] tokens)
{
    var stack = new Stack<int>();
    foreach (string token in tokens)
    {
        bool is_num = int.TryParse(token, out int num);
        if (is_num)
        {
            stack.Push(num);
        }
        else
        {
            int lastNum = stack.Pop();
            stack.Push(expression(stack.Pop(), lastNum, token));
        }
    }
    return stack.Pop();
}
}
