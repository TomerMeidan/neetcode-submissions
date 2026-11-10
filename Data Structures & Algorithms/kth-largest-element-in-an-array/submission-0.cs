public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        PriorityQueue<int, int> q = new PriorityQueue<int,int>();

        for(int i = 0 ; i < nums.Length ; i++){
            q.Enqueue(nums[i], nums[i]);

            if(q.Count > k){
                q.Dequeue();
            }
        }

        if(q.Count == 0) return -1;

        return q.Peek();
    }
}
