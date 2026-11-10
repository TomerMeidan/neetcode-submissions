public class Solution {
        public int MaxArea(int[] heights)
        {
            if (heights == null) return -1;
            if (heights.Length < 2) return 0;

            int leftP = 0, rightP = heights.Length - 1;
            int maxWater = 0, currentWater = 0;

            while(leftP < rightP)
            {
                if(heights[leftP] <= heights[rightP])
                {
                    currentWater = heights[leftP] * (rightP - leftP);
                    leftP++;
                }
                else
                {
                    currentWater = heights[rightP] * (rightP - leftP);
                    rightP--;
                }

                maxWater = Math.Max(currentWater, maxWater);
            }

            return maxWater;
        }
}
