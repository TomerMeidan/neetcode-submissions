public class Solution {
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            List<int> maxNums = new List<int>();
            if (nums == null || k == 0) return maxNums.ToArray();

            Dictionary<int, int> map = new Dictionary<int, int>();

            int maxValue;
            int left = 0;
            for (int right = 0; right < nums.Length; right++)
            {
                int j = 0;
                maxValue = int.MinValue;

                while (j < k && left + j < nums.Length)
                {
                    maxValue = Math.Max(nums[left + j], maxValue);
                    j++;
                }

                if (j < k) 
                    return maxNums.ToArray();

                maxNums.Add(maxValue);
                left++;

            }

            return maxNums.ToArray();
        }
}
