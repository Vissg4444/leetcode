class Solution {
public:
    int search(vector<int>& nums, int target) {
        int l = 0, r = nums.size() - 1;

        while( l <= r)
        {
            int mid = l + ( r - l ) / 2;

            if (target == nums[mid]) return mid;
            else if(nums[l] <= nums[mid]) // mid in left
            {
                if (target > nums[mid] or target < nums[l])
                    l = mid + 1; // outside
                else
                    r = mid - 1; // inside
            }
            else // mid in right
            {
                if ( target < nums[mid] or target > nums[r])
                    r = mid - 1;
                else
                    l = mid + 1;
            }
        }

        return -1;
    }
};
