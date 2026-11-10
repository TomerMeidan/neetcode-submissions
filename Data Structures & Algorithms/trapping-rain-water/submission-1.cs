public class Solution {
        public int Trap(int[] height)
        {
            int left = 0, middle, right = 0;
            int currentMaxLeft = 0, currentMaxRight = 0;
            int totalRainWaterTrapped = 0;

            for (middle = 0; middle < height.Length; middle++)
            {
                // Find Left Min
                left = middle - 1;
                while(left >= 0)
                {
                    currentMaxLeft = Math.Max(currentMaxLeft, height[left]);
                    left--;
                }

                // Find Right Max
                right = middle + 1;
                while (right < height.Length)
                {
                    currentMaxRight = Math.Max(currentMaxRight, height[right]);
                    right++;
                }

                var minHeight = Math.Min(currentMaxLeft, currentMaxRight);
                var amount = minHeight - height[middle];
                if (amount > 0)
                    totalRainWaterTrapped += amount;

                currentMaxLeft = 0;
                currentMaxRight = 0;

            }

            return totalRainWaterTrapped;

        }
}
