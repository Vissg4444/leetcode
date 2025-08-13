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
        dfsSerialize(root);
        return encoded;
    }
    public void dfsSerialize(TreeNode root)
    {
        if (root == null)
        {
            encoded += "N ";
            return;
        }

        encoded += root.val.ToString() + " ";
        dfsSerialize(root.left);
        dfsSerialize(root.right);
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data)
    {
        int indx = 0;
        return dfsDeserialize(data.Split(), ref indx);
    }

    public TreeNode dfsDeserialize(string[] data, ref int indx)
    {
        if (data[indx] == "N") 
        {
            indx++;
            return null;
        }

        TreeNode root = new TreeNode(int.Parse(data[indx]));
        indx++;
        root.left = dfsDeserialize(data, ref indx);
        root.right = dfsDeserialize(data, ref indx);

        return root;
    }
}
