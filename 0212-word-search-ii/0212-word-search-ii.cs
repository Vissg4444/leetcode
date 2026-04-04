public class Solution
{
    public class PrefixTree
    {
        public class TreeNode
        {
            public Dictionary<char, TreeNode> children = new Dictionary<char, TreeNode>();
            public string word = null;
        }

        public TreeNode root = new TreeNode();

        public void Insert(string word)
        {
            TreeNode node = root;
            foreach (char c in word)
            {
                if (!node.children.ContainsKey(c))
                {
                    node.children[c] = new TreeNode();
                }
                node = node.children[c];
            }
            node.word = word;
        }
    }

    public IList<string> FindWords(char[][] board, string[] words)
    {
        PrefixTree trie = new PrefixTree();
        foreach (string word in words)
        {
            trie.Insert(word);
        }

        List<string> result = new List<string>();

        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                Dfs(board, i, j, trie.root, result);
            }
        }

        return result;
    }

    private void Dfs(char[][] board, int i, int j, PrefixTree.TreeNode node, List<string> result)
    {
        if (i < 0 || i >= board.Length || j < 0 || j >= board[i].Length)
            return;

        char c = board[i][j];

        if (c == '#')
            return;

        if (!node.children.TryGetValue(c, out PrefixTree.TreeNode next))
            return;

        if (next.word != null)
        {
            result.Add(next.word);
            next.word = null; // avoid duplicates
        }

        board[i][j] = '#'; // mark visited

        Dfs(board, i - 1, j, next, result); // up
        Dfs(board, i + 1, j, next, result); // down
        Dfs(board, i, j - 1, next, result); // left
        Dfs(board, i, j + 1, next, result); // right

        board[i][j] = c; // restore
    }
}