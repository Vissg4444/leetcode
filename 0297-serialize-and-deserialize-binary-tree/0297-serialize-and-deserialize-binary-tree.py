# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Codec:

    # Encodes a tree to a single string.
    def serialize(self, root: Optional[TreeNode]) -> str:
        seq = [] # not a str, because of multiple digit nums

        def DFS(root):
            nonlocal seq
            if not root: 
                seq.append("N")
                return

            seq.append(str(root.val))
            DFS(root.left)
            DFS(root.right)

        DFS(root)
        return ",".join(seq)
        
    # Decodes your encoded data to tree.
    def deserialize(self, data: str) -> Optional[TreeNode]:       
        self.i = 0

        data = data.split(",")

        def DFS():
            if data[self.i] == "N":
                self.i += 1
                return None

            node = TreeNode(int(data[self.i]))

            self.i += 1

            node.left = DFS()
            node.right = DFS()

            return node

        return DFS()