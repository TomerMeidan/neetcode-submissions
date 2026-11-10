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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {

        ListNode head = new ListNode();
        ListNode p = head;
        ListNode temp;

        while(list1 != null && list2 != null){
            if(list1.val <= list2.val){
                temp = list1;
                list1 = list1.next;
            }else{
                temp = list2;
                list2 = list2.next;
            }
            temp.next = null;
            head.next = temp;
            head = head.next;
        }

        while(list1 != null){
            temp = list1;
            list1 = list1.next;
            temp.next = null;
            head.next = temp;
            head = head.next;
        }

        while(list2 != null){
            temp = list2;
            list2 = list2.next;
            temp.next = null;
            head.next = temp;
            head = head.next;
        }

        return p.next;
    }
}