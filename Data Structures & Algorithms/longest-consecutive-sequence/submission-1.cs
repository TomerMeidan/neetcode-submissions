public class Solution {
        public int LongestConsecutive(int[] nums)
        {
            HashSet<int> hash = new HashSet<int>();
            int maxCount = 0;
            int longest = 0;
            int length = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                hash.Add(nums[i]);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                
                if(!hash.Contains(nums[i] - 1))
                {
                    length = 1;
                    while (hash.Contains(nums[i] + length)) length++;
                    maxCount = Math.Max(length, maxCount);
                }
            }

            return maxCount;
        }
}
