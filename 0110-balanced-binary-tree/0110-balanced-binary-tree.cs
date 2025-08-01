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

    public bool IsBalanced(TreeNode root) {
        bool isBalanced = true;
        DFS(root, ref isBalanced);
        return isBalanced;
    }
    public int DFS(TreeNode root, ref bool isBalanced)
    {
        if (root == null) return 0;

        int l = DFS(root.left, ref isBalanced);
        int r = DFS(root.right, ref isBalanced);

        if (Math.Abs(l - r) > 1)
        {
            isBalanced = false;
        }
        return 1 + Math.Max(l, r);
    }
}
