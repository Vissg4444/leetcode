public class TreeNode()
    {
        public Dictionary<char, TreeNode> children = new Dictionary<char, TreeNode>();
        public bool word = false;
    }

public class WordDictionary {
    private TreeNode root;

    public WordDictionary() {
        root = new TreeNode();
    }
    
    public void AddWord(string word) {
        TreeNode dummy = root;
        foreach (char c in word)
        {
            if (dummy.children.TryGetValue(c, out TreeNode child))
            {
                dummy = child;
            }
            else
            {
                dummy.children.Add(c, new TreeNode());
                dummy = dummy.children[c];
            }
        }
        dummy.word = true;
    }
    public bool Search(string word)
    {
        return Dfs(word, 0, root);
    }
    public bool Dfs(string word, int j, TreeNode root) {
        TreeNode dummy = root;
        for (int i = j; i < word.Length; i++)
        {
            char chr = word[i];
            if (chr == '.')
            {
                foreach (TreeNode child in dummy.children.Values)
                {
                    if (child != null && Dfs(word, i + 1, child))
                        return true;
                }
                return false;
            }
            else
            {
                if (dummy.children.TryGetValue(chr, out TreeNode children))
                {
                    dummy = children;
                }
                else return false;
            }
        }
        return dummy.word;
    }
}
