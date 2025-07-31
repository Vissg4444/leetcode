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
    public int maxval = 0;
    public int DiameterOfBinaryTree(TreeNode root)
    {
        DFS(root);
        return maxval;
    }
    public int DFS(TreeNode root)
    {
        if (root == null) return 0;

        int l = DFS(root.left), r = DFS(root.right);
        maxval = Math.Max(maxval, l + r);
        return 1 + Math.Max(l, r);

    }
}