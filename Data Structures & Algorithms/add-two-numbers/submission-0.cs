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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {

        if(l1 == null) return l2;
        if(l2 == null) return l1;

        int carry = 0;
        ListNode head = new ListNode();
        ListNode tail = head;
        int sum = 0;

        // first while
        while(l1 != null && l2 != null){
            sum = carry + l1.val + l2.val;
            carry = sum / 10;
            sum %= 10;

            tail.next = new ListNode(sum);
            tail = tail.next;
            l1 = l1.next;
            l2 = l2.next;
        }
        // remaininh l1 numbers
        while(l1 != null){
            sum = carry + l1.val;
            carry = sum / 10;
            sum %= 10;

            tail.next = new ListNode(sum);
            tail = tail.next;
            l1 = l1.next;
        }

        // remaining l2 numbers
        while(l2 != null){
            sum = carry + l2.val;
            carry = sum / 10;
            sum %= 10;

            tail.next = new ListNode(sum);
            tail = tail.next;
            l2 = l2.next;
        }

        if(carry == 1){
            tail.next = new ListNode(1);
            tail = tail.next;
        }

        return head.next;
    }
}
