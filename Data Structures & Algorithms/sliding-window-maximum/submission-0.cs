public class Solution {
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            List<int> maxNums = new List<int>();
            if (nums == null || k == 0) return maxNums.ToArray();

            IComparer<int> compare = Comparer<int>.Create((a,b) => b.CompareTo(a));
            PriorityQueue<int,int> queue = new PriorityQueue<int,int>(initialCapacity: k, comparer: compare);

            for(int i = 0; i < nums.Length; i++)
            {
                queue.Clear();
                int j = i;
                while (queue.Count < k && j < nums.Length)
                {

                    queue.Enqueue(j, nums[j]);
                    j++;
                }
                if(queue.Count < k) 
                    return maxNums.ToArray();

                int maxIndex = queue.Dequeue();
                maxNums.Add(nums[maxIndex]);

            }

            return maxNums.ToArray();
        }
}
