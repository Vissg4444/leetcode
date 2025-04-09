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

class Codec {
public:

    // Encodes a tree to a single string.
    string serialize(TreeNode* root) 
    {
        string seq;
        DFS_1(root, seq);
        return seq;
    }

    int DFS_1(TreeNode* root, string &seq)
    {
        if (!root)
        {
            seq.append("N,");
            return 0;
        }

        seq.append(to_string(root->val));
        seq.append(",");
        DFS_1(root->left, seq);
        DFS_1(root->right, seq);

        return 0;
    }

    // Decodes your encoded data to tree.
    TreeNode* deserialize(string data) 
    {
        vector<string> seq = split(data, ',');
        int i = 0;
        return DFS_2(seq, i);
    }

    vector<string> split(const string &s, char delim) 
    {
        vector<string> elems;
        stringstream ss(s);
        string item;
        while (getline(ss, item, delim)) {
            elems.push_back(item);
        }
        return elems;
    }

    TreeNode* DFS_2(vector<string> seq, int &i)
    {
        if (seq[i] == "N")
        {
            i++;
            return NULL;
        }

        TreeNode* root = new TreeNode(stoi(seq[i]));
        i++;
        root->left = DFS_2(seq, i);
        root->right = DFS_2(seq, i);

        return root;
    }
};
