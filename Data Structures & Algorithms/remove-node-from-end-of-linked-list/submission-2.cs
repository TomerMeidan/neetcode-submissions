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
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {

            if (head == null) return head;

            head = ReverseList1(head);

            ListNode prev = null;
            ListNode curr = head;
            int count = n;

            while (curr != null && count > 1)
            {
                prev = curr;
                curr = curr.next;
                count--;
            }

            if (prev == null) 
                head = head.next;       
            else if (curr != null)
                prev.next = curr.next;
            return ReverseList1(head);

        }

                public ListNode ReverseList1(ListNode head)
        {
            if (head == null)
                return head;

            ListNode left = head.next, temp = head, right = head.next;
            temp.next = null;

            while (left != null)
            {
                if (right != null)
                    right = right.next;
                left.next = temp;
                temp = left;
                left = right;
            }

            return temp;
        }
}
