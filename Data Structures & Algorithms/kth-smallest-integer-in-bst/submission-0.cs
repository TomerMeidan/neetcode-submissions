/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
        public int KthSmallest(TreeNode root, int k)
        {
            if (root == null) return 0;
            TreeNode kth = new TreeNode();
            Rec(root, ref k, ref kth);
            return kth.val;
        }

        public void Rec(TreeNode root, ref int k, ref TreeNode kthNode)
        {

            if (root == null) return;

            Rec(root.left, ref k, ref kthNode);

            k--;
            if (k == 0)
            {
                kthNode = root;
                return;
            }
            else if (k < 0) return;

            Rec(root.right, ref k, ref kthNode);


        }
}
