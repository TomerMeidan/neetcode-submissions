public class Solution {
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!map.ContainsKey(nums[i]))
                    map.Add(nums[i], 1);
                else
                    map[nums[i]]++;
            }
            var maxComparer = Comparer<int>.Create((a, b) => b.CompareTo(a));
            PriorityQueue<int, int> queue = new PriorityQueue<int, int>(maxComparer);

            foreach (var item in map)
            {
                queue.Enqueue(item.Key, item.Value);
            }

            int countToDequeue = Math.Min(k, queue.Count);
            int[] results = new int[countToDequeue];

            // 2. Dequeue elements into the array
            for (int i = 0; i < countToDequeue; i++)
            {
                results[i] = queue.Dequeue();
            }

            return results;
        }
}
