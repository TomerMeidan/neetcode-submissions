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
    public int MaxDepth(TreeNode root) {

        if(root == null) return 0;

         Stack<(TreeNode node, int depth)> stack = new Stack<(TreeNode node, int depth)>();
         int maxDepth = 1;

         stack.Push((root, maxDepth));

         while(stack.Count > 0){
            var n = stack.Pop();

            if(n.node.left == null && n.node.right == null){
                maxDepth = Math.Max(maxDepth, n.depth);
            }
            else{
                if (n.node.left != null){
                    stack.Push((n.node.left, n.depth + 1));
                }

                if (n.node.right != null){
                    stack.Push((n.node.right, n.depth + 1));
                }
            }


         }

         return maxDepth;
        
    }
}
