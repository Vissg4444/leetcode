public class MinStack {
    Stack<(int minval, int val)> minstack;
    int minval;
    public MinStack() {
        minstack = new Stack<(int, int)>();
        minval = int.MaxValue;
    }
    
    public void Push(int val) {
        minval = Math.Min(val, !minstack.Any() ? val : minstack.Peek().minval);
        minstack.Push((minval, val));
    }
    
    public void Pop() {
        minstack.Pop();
    }
    
    public int Top() {
        return minstack.Peek().val;
    }
    
    public int GetMin() {
        return minstack.Peek().minval;
    }
}
