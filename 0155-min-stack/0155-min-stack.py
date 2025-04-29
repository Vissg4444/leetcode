class MinStack:

    def __init__(self):
        self.stk = []
        self.stk_min = []

    def push(self, val: int) -> None:
        self.stk.append(val)
        val = min(val, self.stk_min[-1] if self.stk_min else val)
        self.stk_min.append(val)
        
    def pop(self) -> None:
        self.stk.pop()
        self.stk_min.pop()

    def top(self) -> int:
        return self.stk[-1]

    def getMin(self) -> int:
        return self.stk_min[-1]
