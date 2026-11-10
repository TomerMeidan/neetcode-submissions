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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {

        if(root == null && subRoot != null) return false;
        if(root != null && subRoot == null) return true;
        if(root == null && subRoot == null) return true;

        if(SameTree(root,subRoot)) return true;

        return IsSubtree(root.left,subRoot) || IsSubtree(root.right,subRoot);


    }

    public bool SameTree(TreeNode root, TreeNode subRoot){
        if(root == null && subRoot == null) return true;

        if(root != null && subRoot != null && root.val == subRoot.val){
            var resLeft = SameTree(root.left, subRoot.left);
            var resRight = SameTree(root.right, subRoot.right);

            return resLeft && resRight;
        }
        else 
            return false;
    }
}
