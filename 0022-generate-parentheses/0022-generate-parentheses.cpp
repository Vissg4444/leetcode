class Solution {
public:
    void backtrack(int open_brackets, int closed_brackets, int n, string& stk, vector<string>& out)
    {
        if ( open_brackets == closed_brackets and open_brackets == n)
        {
            out.push_back(stk);
            return;
        }
        if ( open_brackets < n)
        {
            stk += "(";
            backtrack(open_brackets + 1, closed_brackets, n, stk, out);
            stk.pop_back();
        }
        if ( closed_brackets < open_brackets)
        {
            stk += ")";
            backtrack(open_brackets, closed_brackets + 1, n, stk, out);
            stk.pop_back();
        }
    }
    vector<string> generateParenthesis(int n) {
        string stk;
        vector<string> out;
        backtrack(0, 0, n, stk, out);
        return out;
    }
};