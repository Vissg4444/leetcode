class Solution:
    def findMin(self, nums: List[int]) -> int:
        l = 0
        r = len(nums) - 1
        if nums[l] < nums[r]: return nums[l]
        num = nums[l]
        target = 1000
        while l <= r:
            mid = int((r + l) / 2)
            if nums[mid] < num:
                r = mid - 1
            elif nums[mid] >= num:
                l = mid + 1
            else:
                return nums[mid]
            target = min(target, nums[mid])
        return target