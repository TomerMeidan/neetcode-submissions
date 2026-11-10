public class Solution {
        public int LongestConsecutive(int[] nums)
        {
            if (nums.Length == 0) return 0;

            Dictionary<int, (int curr, int next)> map = new Dictionary<int, (int curr, int next)>();
            Dictionary<int, int> results = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var numb = nums[i];
                if (!map.ContainsKey(numb))
                {
                    map[numb] = (i, -1);

                    if (map.ContainsKey(numb - 1))
                    {
                        var val = map[numb - 1];
                        val.next = i;
                        map[numb - 1] = val;
                    }

                    if (map.ContainsKey(numb + 1))
                    {
                        var val = map[numb];
                        val.next = map[numb + 1].curr;
                        map[numb] = val;
                    }
                }
            }

            foreach (var numb in map)
            {
                int currConSeqCount = 1;
                int i = 1;
                while (map.ContainsKey(numb.Key + i))
                {
                    if (results.ContainsKey(numb.Key + i))
                    {
                        currConSeqCount += results[numb.Key + i];
                        results.Remove(numb.Key + i);
                        break;
                    }
                    else
                    {
                        currConSeqCount++;
                        map.Remove(numb.Key + i);
                        i++;
                    }
                }

                results[numb.Key] = currConSeqCount;

            }

            int max = 0;
            foreach (var numb in results)
            {
                max = Math.Max(max, numb.Value);
            }

            return max;


        }
}
