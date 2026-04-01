    public class Trie
    {
        public class TreeNode()
        {
            public Dictionary<char, TreeNode> children = new Dictionary<char, TreeNode>();
            public bool end = false;
        }
        TreeNode root;
        public Trie()
        {
            root = new TreeNode();
        }

        public void Insert(string word)
        {
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
            dummy.end = true;
        }

        public bool Search(string word)
        {
            TreeNode dummy = root;
            bool end = false;
            foreach (char c in word)
            {
                if (dummy.children.TryGetValue(c, out TreeNode child))
                        {
                    dummy = child;

                }
                else return false;
            }
            return dummy.end;
        }

        public bool StartsWith(string prefix)
        {
            TreeNode dummy = root;
            int i;
            for (i = 0; i < prefix.Length; i++)
            {
                char chr = prefix[i];
                if (dummy.children.TryGetValue(chr, out TreeNode child))
                    {
                    dummy = child;
                }
                else return false;
            }
            return true;
        }
    }