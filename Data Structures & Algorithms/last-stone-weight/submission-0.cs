public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int,int> q = new PriorityQueue<int,int>(comparer: Comparer<int>.Create((a,b) => b.CompareTo(a)));

        for(int i = 0 ; i < stones.Length ; i++){
            q.Enqueue(stones[i], stones[i]);
        }

        while(q.Count > 1){
            var x = q.Dequeue(); // 1st Biggest
            var y = q.Dequeue(); // 2nd Biggest

            if(x - y > 0) q.Enqueue(x-y,x-y);
        }

        return q.Count == 1 ? q.Dequeue() : 0;
    }
}
