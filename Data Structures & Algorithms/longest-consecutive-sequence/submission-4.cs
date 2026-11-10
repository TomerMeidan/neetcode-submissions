public class Solution {
        public int LongestConsecutive(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int max = 0;
            HashSet<int> map = new  HashSet<int>();
            Dictionary<int, int> results = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var numb = nums[i];
                map.Add(numb);
            }

            foreach (var numb in map)
            {
                int currConSeqCount = 1;
                int i = 1;
                while (map.Contains(numb + i))
                {
                    if (results.ContainsKey(numb + i))
                    {
                        currConSeqCount += results[numb + i];
                        results.Remove(numb + i);
                        break;
                    }
                    else
                    {
                        currConSeqCount++;
                        map.Remove(numb + i);
                        i++;
                    }
                }

                max = Math.Max(max, currConSeqCount);
                results[numb] = currConSeqCount;
            }

            return max;

        }
}
