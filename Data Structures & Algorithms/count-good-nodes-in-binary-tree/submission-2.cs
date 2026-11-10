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
        public void Rec(TreeNode root, TreeNode lastMaxNode, ref int count)
        {
            if (root == null) return;

            TreeNode currentMax = root; 

            if (root.val < lastMaxNode.val)
            {
                currentMax = lastMaxNode;
            }
            else
            {
                currentMax = root;
                count++;
            }

            Rec(root.left, currentMax, ref count);
            Rec(root.right, currentMax, ref count);

        }

        public int GoodNodes(TreeNode root)
        {
            if (root == null) return -1;
            int count = 0;
            Rec(root, root, ref count);
            return count;
        }
}
