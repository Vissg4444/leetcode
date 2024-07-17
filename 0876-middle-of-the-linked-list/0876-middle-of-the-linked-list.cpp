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
    ListNode* middleNode(ListNode* head) 
    {
        int size = 0, i = 1;
        ListNode* middle = head; 
        for (ListNode *temp = head; temp->next != NULL; temp = temp->next, i++ );
        size = i / 2;
        for(i = 0; i != size; i++)
            middle = middle->next;
        return middle;
    } 
};