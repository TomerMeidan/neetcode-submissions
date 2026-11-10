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
        public void Rec(TreeNode root, ref Dictionary<TreeNode, TreeNode> map, TreeNode lastMaxNode, ref int count)
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

            map[root] = lastMaxNode;

            Rec(root.left, ref map, currentMax, ref count);
            Rec(root.right, ref map, currentMax, ref count);

        }

        public int GoodNodes(TreeNode root)
        {
            if (root == null) return -1;
            int goodNodesCount = 0;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            Dictionary<TreeNode, TreeNode> maxMap = new Dictionary<TreeNode, TreeNode>();

            queue.Enqueue(root);
            maxMap.Add(root, root);
            int count = 0;
            TreeNode currentMaxNode = root;
            Rec(root, ref maxMap, currentMaxNode, ref count);

            return count;


        }
}
