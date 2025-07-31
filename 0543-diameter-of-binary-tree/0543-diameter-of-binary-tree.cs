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
    public int DiameterOfBinaryTree(TreeNode root)
    {
        if (root == null) return 0;
        int maxval = 0;
        DFS(root, ref maxval);
        return maxval;


    }
    public int DFS(TreeNode root, ref int maxval)
    {
        if (root == null) return 0;

        int l = DFS(root.left, ref maxval), r = DFS(root.right, ref maxval);
        maxval = Math.Max(maxval, l + r);
        return 1 + Math.Max(l, r);

    }
}