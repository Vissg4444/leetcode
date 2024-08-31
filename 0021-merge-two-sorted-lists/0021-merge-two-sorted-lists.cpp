/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode() : val(0), next(nullptr) {}
 *     ListNode(int x) : val(x), next(nullptr) {}
 *     ListNode(int x, ListNode *next) : val(x), next(next) {}
 * };
 */
class Solution {
public:
    ListNode* mergeTwoLists(ListNode* list1, ListNode* list2) {
       vector<int> nums;
       for(ListNode* i = list1; i != NULL; i = i->next)
       {
        nums.push_back(i->val);
       }
       for(ListNode* i = list2; i != NULL; i = i->next)
       {
        nums.push_back(i->val);
       }
       sort(nums.begin(), nums.end());
       
       ListNode *temp = new ListNode(-1);
       ListNode *head = temp;
       for( int i = 0; i < nums.size(); i++)
       {
        temp->next = new ListNode(nums[i]);
        temp = temp->next;
       }
       head = head->next;
       return head;
        
    }
};