public class Solution {
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            List<int> maxNums = new List<int>();
            if (nums == null || k == 0) return maxNums.ToArray();

            Dictionary<int, int> map = new Dictionary<int, int>();
            IComparer<int> comparer = Comparer<int>.Create((int a, int b) => b.CompareTo(a));
            PriorityQueue<int, int> queue = new PriorityQueue<int, int>(comparer);

            int maxValue;
            int left = 0;
            for (int right = 0; right < nums.Length; right++)
            {

                if (map.ContainsKey(nums[right]))
                    map[nums[right]]++;
                else
                    map[nums[right]] = 1;

                queue.Enqueue(nums[right], nums[right]);

                if (queue.Count == k)
                {
                    maxValue = queue.Peek();
                    maxNums.Add(maxValue);
                }

                if (queue.Count > k)
                {
                    map[nums[left++]]--;

                    var maxVal = queue.Peek();
                    while(map.ContainsKey(maxVal) && map[maxVal] == 0)
                    {
                        while (queue.Peek() == maxVal)
                        {
                            queue.Dequeue();
                        }

                        maxVal = queue.Peek();
                    }

                    maxValue = queue.Peek();
                    maxNums.Add(maxValue);

                }



            }

            return maxNums.ToArray();
        }
}
