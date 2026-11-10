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
// 1 2 3 4 5 6
// 1 2 3 6 5 4

public class Solution {
    public void ReorderList(ListNode head) {

        if(head == null) return;

        ListNode slow = head; // center index in linked list
        ListNode fast = head.next;

        while(fast != null && fast.next != null){
            slow = slow.next;
            fast = fast.next.next;
        }

        slow.next = ReverseList(slow.next);
        var p = head;
        var rev = slow.next;
        slow.next = null;

        while(rev != null){
            ListNode temp = rev.next;
            rev.next = p.next;
            p.next = rev;
            p = p.next.next;
            rev = temp;
        }
        
    }

    public ListNode ReverseList(ListNode head){
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
