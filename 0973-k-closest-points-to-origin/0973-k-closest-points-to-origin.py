class Solution:
    def kClosest(self, points: List[List[int]], k: int) -> List[List[int]]:
        heap = [] # (Len to 0, point)
        out = []

        for point in points:
            heapq.heappush(heap, (math.sqrt(pow(point[0], 2) + pow(point[1], 2)), point))
        for i in range(k):
            elem = heapq.heappop(heap)
            out.append([elem[1][0], elem[1][1]])

        return out
