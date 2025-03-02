class Solution {
public:
    int findDuplicate(vector<int>& nums) {
        int slow = 0, fast = 0;

        while(1)
        {
            slow = nums[slow];
            fast = nums[nums[fast]]; // 2 times faster;
            if (slow == fast)
                break; // found the node, in p steps start of the loop
        }

        int slow2 = 0;

        while(1)
        {
            slow = nums[slow];
            slow2= nums[slow2];
            if (slow == slow2)
                return slow2;
        }
    }
};
