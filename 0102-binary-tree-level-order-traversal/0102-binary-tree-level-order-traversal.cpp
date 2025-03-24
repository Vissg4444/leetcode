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
    vector<vector<int>> levelOrder(TreeNode* root) {
        int max_depth = maxDepth(root);    
        vector<vector<int>> out(max_depth);
        int k = 0;
        DFS(root, out, k);
        return out;
    }
    void DFS(TreeNode* root, vector<vector<int>> &out, int k)
    {
        if(!root) return;
        out[k].push_back(root->val);
        DFS(root->left, out, k + 1);
        DFS(root->right, out, k + 1);
    }
    int maxDepth(TreeNode* root) {
        if (root) return 1 + max(maxDepth(root->left),maxDepth(root->right));
        else return 0;
    }
};
