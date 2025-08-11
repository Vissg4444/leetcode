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
    List<IList<int>> arr = new List<IList<int>>();
    public IList<IList<int>> LevelOrder(TreeNode root) {


        DFS(root, 0);

        return arr; 
    }

    public void DFS(TreeNode root, int level)
    {
        if (root == null) return;

        if (arr.Count == level)
        {
            arr.Add(new List<int>());
        }
        arr[level].Add(root.val);

        DFS(root.left, level + 1);
        DFS(root.right, level + 1);
    }
}