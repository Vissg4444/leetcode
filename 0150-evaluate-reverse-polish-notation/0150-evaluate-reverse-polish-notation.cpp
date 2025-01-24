class Solution {
public:
    int evalRPN(vector<string>& tokens) {
        int out = 0;
        stack<int> stk;
        string operators = "+-*/";
        for (string str : tokens)
        {
            if(operators.find(str) != string::npos)
            {
                int elem2 = stk.top(); stk.pop();
                
                int elem1 = stk.top(); stk.pop();
                
                if(str == "+")
                    stk.push(elem1 + elem2);
                else if(str == "-")
                    stk.push(elem1 - elem2);
                else if(str == "*")
                    stk.push(elem1 * elem2);
                else if(str == "/")
                    stk.push(elem1 / elem2);
            }
            else
                stk.push(stoi(str));
        }
        return stk.top();
    }
};