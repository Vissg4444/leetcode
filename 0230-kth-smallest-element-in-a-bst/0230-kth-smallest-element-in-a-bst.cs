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
    public int count = 0, target = 0;
    public int KthSmallest(TreeNode root, int k) {
        DFS(root, k);
        return target;
    }

    public void DFS(TreeNode root, int k)
    {
        if (root == null) return;
        
        DFS(root.left, k);
        count++;  
        if (count == k)
        {
            target = root.val;
            return;
        }
        DFS(root.right, k);         
       
    }
}
