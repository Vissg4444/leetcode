class Solution {
public:
    int finalPositionOfSnake(int n, vector<string>& commands) {
        int x = 0;
        for (string s : commands)
        {
            if (s == "DOWN")
                x += n;
            else if (s == "UP")
                x -= n;
            else if (s == "RIGHT")
                x += 1;
            else
                x -= 1;
        }
        return x;
    }
};