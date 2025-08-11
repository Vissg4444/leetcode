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
    public int count = 0;
    public int GoodNodes(TreeNode root) {
        DFS(root, root.val);

        return count;
    }
    public void DFS(TreeNode root, int maxval)
    {
        if (root == null) return;

        if (root.val >= maxval) count++;
        maxval = Math.Max(root.val, maxval);

        DFS(root.left, maxval);
        DFS(root.right, maxval);
    }
}