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
    int good = 0;
    int goodNodes(TreeNode* root) {
        if(!root) return 0;
        DFS(root, root->val);
        return good;
    }
    void DFS(TreeNode* root, int maxval)
    {
        if(!root) return;
        if(root->val >= maxval) good++;
        maxval = max(maxval, root->val);
        DFS(root->left, maxval);
        DFS(root->right, maxval);
    }
};
