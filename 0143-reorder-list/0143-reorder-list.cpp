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

    void reorderList(ListNode* head) {

        ListNode* fast = head->next;
        ListNode* slow = head;

        while (fast and fast->next) // finding middle
        {
            slow = slow->next;
            fast = fast->next->next;
        }

        ListNode* second = slow->next;
        ListNode* prev = slow->next = NULL;
        while (second) // reversing
        {
            ListNode* next = second->next;
            second->next = prev;
            prev = second;
            second = next;
        }
        second = prev; // second - beginning of reversed list
        ListNode* first = head; // first - beginning of list
        
        while(second)
        {
            ListNode* next1 = first->next;
            ListNode* next2 = second->next;

            first->next = second;
            second->next = next1;
            first = next1;
            second = next2;
        }
        
    }
};
