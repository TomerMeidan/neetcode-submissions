public class Solution {
        public int LargestRectangleArea(int[] heights)
        {

            if (heights == null || heights.Length == 0) return 0;
            if(heights.Length == 1) return heights[0];

            int maxArea = 0;
            int minHeight = 0;
            int currentArea = 0;

            for (int i = 0; i < heights.Length; i++)
            {
                minHeight = heights[i];
                maxArea = Math.Max(maxArea, heights[i]);

                for (int j = i + 1; j < heights.Length; j++)
                {
                    minHeight = Math.Min(minHeight, heights[j]);
                    currentArea = minHeight * (j - i + 1);
                    maxArea = Math.Max(maxArea, currentArea);
                }

                currentArea = minHeight * (heights.Length - i);
                maxArea = Math.Max(maxArea, currentArea);
            }

            return maxArea;
        }
}
