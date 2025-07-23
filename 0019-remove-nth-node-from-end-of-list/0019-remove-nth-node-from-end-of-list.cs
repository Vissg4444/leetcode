/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        int size = 0;
        ListNode dummy = new ListNode(0, head);
        ListNode curr = head;

        while (curr != null)
        {
            size++;
            curr = curr.next;
        }

        curr = head;
        ListNode prev = null;

        int N = size - n;
        if (N == 0)
            return head.next;
        for(int i = 0; i < N; i++)
        {
            prev = curr;
            curr = curr.next;
        }
        
        prev.next = curr.next;
        return dummy.next;
    }
}
