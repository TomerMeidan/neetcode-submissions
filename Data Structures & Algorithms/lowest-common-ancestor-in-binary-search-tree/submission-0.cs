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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if(root == null) return null;
        TreeNode current = root;

        while(current != null){
            if(current.val < p.val && current.val < q.val) current = current.right;
            else if(current.val > p.val && current.val > q.val) current = current.left;
            else if(current.val <= p.val && current.val >= q.val) return current;
            else if(current.val >= p.val && current.val <= q.val) return current;
        }

        return null;

    }
}
