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
        public ListNode MergeKLists(ListNode[] lists)
        {
            if(lists.Length == 0)  
                return null;
            if(lists.Length == 1)  
                return lists[0];

            var list = lists[0];

            for (int i = 1; i < lists.Length; i++)
            {
                list = MergeTwoLists(list, lists[i]);
            }

            return list;
        }

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if(list1 == null && list2 == null) return new ListNode();
            if(list2 == null && list1 != null) return list1;
            if(list1 == null && list2 != null) return list2;

            ListNode head = new ListNode();
            ListNode p = head;

            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {

                    head.next = new ListNode(list1.val);
                    list1 = list1.next;
                }
                else
                {
                    head.next = new ListNode(list2.val);
                    list2 = list2.next;
                }
                head = head.next;
            }

            while (list1 != null)
            {
                head.next = new ListNode(list1.val);
                list1 = list1.next;
                head = head.next;
            }

            while (list2 != null)
            {
                head.next = new ListNode(list2.val);
                list2 = list2.next;
                head = head.next;
            }

            return p.next;
        }
}
