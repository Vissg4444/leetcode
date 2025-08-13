/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Codec {
    public string encoded = "";
    // Encodes a tree to a single string.
    public string serialize(TreeNode root)
    {
        if (root == null) return "";
        return root.val.ToString() + " " + serialize(root.left) + " " + serialize(root.right);
    }
    public TreeNode deserialize(string data) {
        string[] tokens = data.Split(' ');
        var q = new Queue<string>(tokens);
        return Traverse(q);
        /*TreeNode root = new TreeNode(tokens.First());
        TreeNode current = root;
        foreach (string token in tokens) {
            if (token == "*")
        }*/
    }
    private TreeNode Traverse(Queue<string> q) {
        string c = q.Count > 0 ? q.Dequeue() : null;
        return string.IsNullOrEmpty(c) ? null : new TreeNode(int.Parse(c), Traverse(q), Traverse(q));
    }
}
