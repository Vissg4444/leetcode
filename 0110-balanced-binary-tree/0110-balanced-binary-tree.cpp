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
    bool isBalanced(TreeNode* root) {
        bool isBalanced = true;
        dfs(root, isBalanced);
        return isBalanced;
    }

    int dfs(TreeNode* node, bool &isBalanced)
    {
        if (!node) return 0;

        int left = dfs(node->left, isBalanced);
        int right = dfs(node->right, isBalanced);

        if (abs(left - right) > 1) 
            isBalanced = false;

        return 1 + max(left, right);
    }
};
