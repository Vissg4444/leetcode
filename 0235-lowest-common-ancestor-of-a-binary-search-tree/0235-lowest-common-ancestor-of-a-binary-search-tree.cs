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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        
        int low = (p.val > q.val ? q.val : p.val );
        int high = (p.val > q.val ? p.val : q.val);

        while (root != null)
        {
            if (high >= root.val && low <= root.val ) return root;

            else if (high >= root.val && low >= root.val)
            {
                root = root.right;
            }
            else
            {
                root = root.left;
            }
        }
        return null;
    }
}
