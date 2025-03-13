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
        
       ListNode *head = new ListNode(0);
       ListNode *node = head;
       
       while (list1 and list2)
       {
        if(list1->val < list2->val)
        {
            node->next = list1;
            list1 = list1->next;
        }
        else
        {
            node->next = list2;
            list2 = list2->next;
        }
        node = node->next;
       }

        if(list1)
            node->next = list1;
        else
            node->next = list2;
            
        return head->next;
    }
    
    ListNode* mergeKLists(vector<ListNode*>& lists) {
        if(!lists.size()) return NULL;
        for(int i = 1; i < lists.size(); i++)
        {
            lists[i] = mergeTwoLists(lists[i-1], lists[i]);
        }
        return lists.back();
    }
};
