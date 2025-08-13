/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     TreeNode *left;
 *     TreeNode *right;
 *     TreeNode() : val(0), left(nullptr), right(nullptr) {}
 *     TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
 *     TreeNode(int x, TreeNode *left, TreeNode *right) : val(x), left(left), right(right) {}
 * };
 */

class Solution {
public:

    int maxPathSum(TreeNode* root) {
        int out = root->val;
        DFS(root, out);
        return out;

    }

    int DFS(TreeNode* root, int& out)
    {
        if (!root) return 0;

        int left = max(DFS(root->left, out), 0);
        int right = max(DFS(root->right, out), 0);

        out = max(out, root->val + left + right);

        return root->val + max(left, right);

    }
};
