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
    public void ReorderList(ListNode head) {
        ListNode slow = head, fast = head.next;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        ListNode l2 = slow.next;
        ListNode prev = slow.next = null;
        while (l2 != null) // reversing
        {
            ListNode next = l2.next;
            l2.next = prev;
            prev = l2;
            l2 = next;
        }

        l2 = prev;
        ListNode first = head;

        while (l2 != null)
        {
            ListNode next1 = first.next;
            ListNode next2 = l2.next;

            first.next = l2;
            l2.next = next1;
            first = next1;
            l2 = next2;
        }
        
    }

}
