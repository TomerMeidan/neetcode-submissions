public class Solution {
        public int Trap(int[] height)
        {
            int left = 0;
            int right = 0;
            int currentSum = 0;
            int maxSum = 0;
            int maybeWater = 0;

            for (right = 0; right < height.Length; right++)
            {

                while (right < height.Length && height[right] < height[left])
                {
                    if(right < height.Length - 1 && height[right] < height[right + 1] && height[right + 1] < height[left])
                    {
                        int maybeHeight = height[right + 1];
                        maybeWater = 0;
                        for (int i = left + 1; i < right + 1; i++)
                        {
                            if (maybeHeight >= height[i])
                                maybeWater += maybeHeight - height[i];
                        }
                    }
                        
                    currentSum += height[left] - height[right];
                    right++;
                }

                if (right < height.Length && height[right] >= height[left])
                {
                    maybeWater = 0;
                    maxSum += currentSum;
                    left = right;
                    currentSum = 0;
                }

            }

            return maxSum + maybeWater;
        }
}
