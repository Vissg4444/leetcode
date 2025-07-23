/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node CopyRandomList(Node head)
    {
        var hash = new Dictionary<Node, Node>();

        Node cur = head;
        while (cur != null)
        {
            Node copy = new Node(cur.val);
            hash[cur] = copy;
            cur = cur.next;
        }

        cur = head;
        while (cur != null) 
        {
            Node copy = hash[cur];
            copy.next = cur.next != null ? hash[cur.next] : null;
            copy.random = cur.random != null ? hash[cur.random] : null;
            cur = cur.next;
        }
        
        return head != null ? hash[head] : null;
    }
}
