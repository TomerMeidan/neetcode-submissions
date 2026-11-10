public class Solution {
        public int MaxArea(int[] heights)
        {
            int left = 0, right = heights.Length - 1;
            int mostWater = 0, currentWater = 0;
            int minWall = 0;

            while (left < right)
            {

                minWall = Math.Min(heights[left], heights[right]);
                currentWater = minWall * (right - left);
                mostWater = Math.Max(mostWater, currentWater);

                if (heights[left] < heights[right])
                    left++;
                else
                    right--;
            }

            return mostWater;
        }
}
