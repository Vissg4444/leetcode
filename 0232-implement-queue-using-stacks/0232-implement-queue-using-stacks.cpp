
class MyQueue {
public:
    stack<int> rstk, wstk;
    MyQueue() {}

    void push(int x) { wstk.push(x); }

    int pop() {
        peek();
        int val = rstk.top();
        rstk.pop();
        return val;
    }

    int peek() {
        if (rstk.empty()) {
            while (!wstk.empty()) {
                rstk.push(wstk.top());
                wstk.pop();
            }
        }
        return rstk.top();
    }

    bool empty() { return (rstk.empty() && wstk.empty()); }
};