public class Solution {
        public int Trap(int[] height)
        {
            int[] maxLeft = new int[height.Length];
            int[] maxRight= new int[height.Length];
            int currentMaxLeft = 0, currentMaxRight = 0;
            int rainWaterTrapped = 0;

            for (int i = 0; i < height.Length; i++)
            {
                if( i - 1 >= 0)
                {
                    currentMaxLeft = Math.Max(currentMaxLeft, height[i - 1]);
                    maxLeft[i] = currentMaxLeft;
                }
                else
                {
                    maxLeft[i] = 0;
                }
            }

            for (int i = height.Length - 1; i >= 0; i--)
            {
                if (i + 1 < height.Length)
                {
                    currentMaxRight = Math.Max(currentMaxRight, height[i + 1]);
                    maxRight[i] = currentMaxRight;
                }
                else
                {
                    maxRight[i] = 0;
                }
            }

            for (int i = 0; i < height.Length; i++)
            {
                var minHeight = Math.Min(maxLeft[i], maxRight[i]);
                var amount = minHeight - height[i];
                if(amount > 0)
                    rainWaterTrapped += amount;
            }

            return rainWaterTrapped;
        }
}
