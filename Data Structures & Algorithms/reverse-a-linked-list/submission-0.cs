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
        public ListNode ReverseList(ListNode head)
        {
            ListNode left, temp, right;

            if (head == null) 
                return head;

            temp = head;
            right = head.next;
            left = head.next;
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
