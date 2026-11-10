public class Solution {
        public int FindMin(int[] nums)
        {

            int left = 0;
            int right = nums.Length - 1;
            int minValue = int.MaxValue;

            while (left <= right)
            {
                int middle = left + (right - left) / 2;

                if (nums[0] <= nums[middle])
                {
                    var currentMin = Math.Min(nums[0], nums[middle]);
                    minValue = Math.Min(minValue, currentMin);
                    left = middle + 1;
                }                
                else if (nums[0] > nums[middle])
                {
                    minValue = Math.Min(minValue, nums[middle]);
                    right = middle - 1;
                }

            }

            return minValue;

        }
}
