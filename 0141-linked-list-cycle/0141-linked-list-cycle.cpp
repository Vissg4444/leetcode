/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode(int x) : val(x), next(NULL) {}
 * };
 */
class Solution {
public:
    bool hasCycle(ListNode *head) 
    {
        set<int> s;
        while(true)
        {
            if (head)
            {   if (s.contains(head->val))
                    return true;
                s.insert(head->val);
                if (head->next == NULL)
                    return false;
                head = head->next;
            }
            else
                return false;
        }

    }
};