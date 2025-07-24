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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        string s1 = "", s2 = "";

        ListNode curr = l1;
        while (curr != null)
        {
            s1 += curr.val.ToString();
            curr = curr.next;
        }

        curr = l2;
        while (curr != null)
        {
            s2 += curr.val.ToString();
            curr = curr.next;
        }

        string s1_r = string.Concat(s1.Reverse());
        string s2_r = string.Concat(s2.Reverse());
        long sum = long.Parse(s1_r) + long.Parse(s2_r);

        ListNode head = new ListNode(0, null);
        curr = head;
        if (sum == 0) return head;
        while ( sum > 0)
        {
            int digit = (int)(sum % 10);
            curr.next = new ListNode(digit, null);
            curr = curr.next;
            sum = sum / 10;
        }
        return head.next;
    }
}
