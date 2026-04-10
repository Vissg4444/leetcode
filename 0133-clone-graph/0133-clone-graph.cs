using System.Runtime.CompilerServices;
public class Solution
{
    
    Dictionary<Node, Node> cloned = new Dictionary<Node, Node>();
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public Node CloneGraph(Node node)
    {
        return DFS(node);
    }
    public Node DFS(Node node)
    {
        if (node == null)
            return null;
        if (cloned.ContainsKey(node)) 
            return cloned[node];

        Node NewNode = new Node(node.val);
        cloned[node] = NewNode;

        foreach (Node neighbor in node.neighbors)
            NewNode.neighbors.Add(DFS(neighbor));

        return NewNode;
    }
}