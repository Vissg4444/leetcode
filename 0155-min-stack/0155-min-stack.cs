public class MinStack {
    Stack<(int minval, int val)> minstack;
    int minval;
    public MinStack() {
        minstack = new Stack<(int, int)>();
    }
    
    public void Push(int val) {
        int min;
        if (minstack.Count == 0) 
            min = val;
        else 
            min = Math.Min(val, minstack.Peek().minval);
        minstack.Push((min, val));
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
