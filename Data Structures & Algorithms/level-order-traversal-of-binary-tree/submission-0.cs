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
    public List<List<int>> LevelOrder(TreeNode root) {

        List<List<int>> list = new List<List<int>>();
        Queue<TreeNode> q = new Queue<TreeNode>();
        if(root == null) return list;

        q.Enqueue(root);

        while(q.Count > 0){

            int levelNodesCount = q.Count;
            List<int> levelList = new List<int>();

            for(int i = 0 ; i < levelNodesCount ; i++){
                var node = q.Dequeue();
                levelList.Add(node.val);

                if(node.left != null) q.Enqueue(node.left);
                if(node.right != null) q.Enqueue(node.right);

            }

            list.Add(levelList);
                
        }

        return list;


    }
}
