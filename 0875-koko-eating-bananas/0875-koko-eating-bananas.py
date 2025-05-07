class Solution:
    def minEatingSpeed(self, piles: List[int], h: int) -> int:
        l = 1
        r = max(piles)
        min_k = r
        while l <= r:
            mid = int(l + ( r - l ) / 2)
            total_time = 0
            for p in piles:
                total_time += math.ceil(float(p) / mid)
            if total_time <= h:
                min_k = mid
                r = mid - 1
            else:
                l = mid + 1
        return min_k

