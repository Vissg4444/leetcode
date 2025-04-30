class Solution:
    def evalRPN(self, tokens: List[str]) -> int:
        stk = []
        operators = "+-*/"
        for elem in tokens:
            if elem not in operators:
                stk.append(int(elem))
            else:
                first = stk.pop()
                second = stk.pop()
                if elem == "+":
                    stk.append(first + second)
                elif elem == "-":
                    stk.append(second - first)
                elif elem == "*":
                    stk.append(first * second)
                else:
                    stk.append(int(second / first))
        return stk[-1]
