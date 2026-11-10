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

        public int DiameterOfBinaryTree(TreeNode root)
        { 
            int res = 0;
            if (root == null) return 0;
            DFS(root, ref res);
            return res;
        }

        public int DFS(TreeNode root, ref int res)
        {
            if (root == null) return 0;
            int leftLength = DFS(root.left,ref res);
            int rightLength = DFS(root.right,ref res);
            res = Math.Max(leftLength + rightLength, res);
            return 1 + Math.Max(leftLength, rightLength);
        }
}
