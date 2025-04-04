# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def maxPathSum(self, root: Optional[TreeNode]) -> int:

        out = root.val

        def DFS(root):
            nonlocal out

            if not root: return 0

            left = DFS(root.left)
            right = DFS(root.right)
            left = max(left, 0)
            right = max(right, 0)

            out = max(out, root.val, root.val + left + right)

            return root.val + max(left, right)
        
        DFS(root)
        return out