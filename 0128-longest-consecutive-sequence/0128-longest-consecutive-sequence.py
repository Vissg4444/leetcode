class Solution:
    def longestConsecutive(self, nums: List[int]) -> int:
        if (len(nums) == 0): return 0
        out = 0
        nums_set = set(nums)

        for num in nums_set:
            if (num - 1) not in nums_set:
                length = 1
                while (num + length) in nums_set:
                    length += 1
                out = max(out, length)
        return out