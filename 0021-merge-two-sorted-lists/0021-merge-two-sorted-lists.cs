public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode curr = new ListNode(0), dummy = curr;

        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                curr.next = new ListNode(list1.val);
                list1 = list1.next;
            }
            else
            {
                curr.next = new ListNode(list2.val);  
                list2 = list2.next;
            }
            curr = curr.next;
        }
        
        if( list1 != null)
            curr.next = list1;
        else
            curr.next = list2;

        return dummy.next;
    }
}