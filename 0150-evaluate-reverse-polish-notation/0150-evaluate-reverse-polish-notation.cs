public class Solution {
    public int EvalRPN(string[] tokens)
    {
        var stack = new Stack<int>();
        foreach (string num in tokens)
        {
            int num1, num2;
            switch (num)
            {
                case ("+"):
                    num1 = stack.Pop();
                    num2 = stack.Pop();
                    stack.Push(num1 + num2);
                    break;
                case ("*"):
                    num1 = stack.Pop();
                    num2 = stack.Pop();
                    stack.Push(num1 * num2);
                    break;
                case ("-"):
                    num1 = stack.Pop();
                    num2 = stack.Pop();
                    stack.Push(num2 - num1);
                    break;
                case ("/"):
                    num1 = stack.Pop();
                    num2 = stack.Pop();
                    stack.Push(num2 / num1);
                    break;
                default:
                    stack.Push(int.Parse(num));
                    break;
            }
        }
        return stack.Peek();
    }
}
