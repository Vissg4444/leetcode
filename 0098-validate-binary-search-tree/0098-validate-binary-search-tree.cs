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

    public bool IsValidBST(TreeNode root) {
        return DFS(root, long.MinValue, long.MaxValue);
    }

    public bool DFS(TreeNode root, long left, long right)
    {
        if (root == null) return true;

        if (!(left < root.val && root.val < right)) return false;

        return DFS(root.left, left, root.val) && DFS(root.right, root.val, right);
    }
}