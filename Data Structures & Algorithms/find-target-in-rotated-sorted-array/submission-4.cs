public class Solution {
        public int Search(int[] nums, int target)
        {

            if (nums == null || nums.Length == 0) return -1;

            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int middle = left + (right - left) / 2;
                if(nums[middle] == target) return middle;

            if (nums[left] <= nums[middle]) {
                if (target > nums[middle] || target < nums[left]) {
                    left = middle + 1;
                } else {
                    right = middle - 1;
                }
            } else {
                if (target < nums[middle] || target > nums[right]) {
                    right = middle - 1;
                } else {
                    left = middle + 1;
                }
            }

            }
            return -1;
        }
}
