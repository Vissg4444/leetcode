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
    int kthSmallest(TreeNode* root, int k) {
        vector<int> out;

        DFS(root, out);

        return out[k-1];
    }

    void DFS(TreeNode* root, vector<int> &out)
    {
        if(!root) return;

        DFS(root->left, out);
        out.push_back(root->val);
        DFS(root->right, out);

        return;
    }
};