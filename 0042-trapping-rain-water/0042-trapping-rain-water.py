class Solution:
    def trap(self, height: List[int]) -> int:
        n = len(height)
        if not n: return 0
        leftMax = [0] * n
        rightMax = [0] * n

        leftMax[0] = height[0]

        for i in range(1 , n):
            leftMax[i] = max(leftMax[i - 1], height[i])
        
        rightMax[n - 1] = height[n - 1]

        for i in range(n - 2, 0, -1):
            rightMax[i] = max(rightMax[i + 1], height[i])

        out = 0
        for i in range(1, n):
            out += min(leftMax[i], rightMax[i]) - height[i]
        return out
       