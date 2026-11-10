/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
        public Node copyRandomList(Node head)
        {

            Node origin = head;
            Node deepCopy = new Node(0);
            Node tail = deepCopy;
            Dictionary<Node, Node> map = new Dictionary<Node, Node>(); // Origin/New

            while (origin != null)
            {
                tail.next = new Node(origin.val);
                tail = tail.next;
                origin = origin.next;
            }

            tail = deepCopy.next;
            origin = head;

            while (tail != null)
            {
                map.Add(origin, tail);
                origin = origin.next;
                tail = tail.next;
            }

            tail = deepCopy.next;
            origin = head;

            while (origin != null)
            {

                if (origin.random == null)
                {
                    tail.random = null;
                }
                else
                {
                    tail.random = map[origin.random];         
                }

                origin = origin.next;
                tail = tail.next;
            }

            return deepCopy.next;
        }
}
