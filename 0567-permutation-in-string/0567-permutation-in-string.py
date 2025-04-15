class Solution:
    def checkInclusion(self, s1: str, s2: str) -> bool:
        if (len(s1) > len(s2)): return False
        s1_d, s2_d = [0] * 26, [0] * 26

        for s in s1:
            s1_d[ord(s) - ord('a')] += 1

        l = 0
        for r in range(len(s2)):
            if (s2_d == s1_d): return True
            index = ord(s2[r]) - ord('a')
            s2_d[index] += 1
            while (s2_d[index] > s1_d[index]):
                s2_d[ord(s2[l]) - ord('a')] -= 1
                l += 1
            
        return s2_d == s1_d