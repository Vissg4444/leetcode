class Solution:
    def merge(self, intervals: List[List[int]]) -> List[List[int]]:
        stack = []
        intervals.sort(key = lambda val: val[1])
        for val in intervals:
            if not stack:
                stack.append(val)
                continue
            while stack and val[0] <= stack[-1][1]:
                val[0] = min(val[0], stack[-1][0])
                stack.pop()
            stack.append(val)
        return stack