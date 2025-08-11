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
public class Solution {
    public List<int> result = new List<int>();
    public List<List<int>> tree = new List<List<int>>();

    public List<int> RightSideView(TreeNode root) {
        DFS(root, 0);

        foreach (List<int> l in tree)
        {
            result.Add(l[^1]);
        }
        return result;
    }
    public void DFS(TreeNode root, int h)
    {
        if (root == null) return;

        if (tree.Count == h)
        {
            tree.Add(new List<int>());
        }
        tree[h].Add(root.val);
        DFS(root.left, h + 1);
        DFS(root.right, h + 1);

    }
}