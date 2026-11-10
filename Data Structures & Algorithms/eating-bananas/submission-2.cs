public class Solution {
        public int MinEatingSpeed(int[] piles, int h)
        {
            int maxValue = 0;
            int bestEatingRateSoFar = int.MaxValue;

            foreach (var item in piles)
            {
                maxValue = Math.Max(maxValue, item);
            }

            Array.Sort(piles);

            int left = 1;
            int right = maxValue;
            int middle = 1;

            while (left <= right)
            {        
                bool res = CanEatAllBananas(piles, middle, h);

                if (res)
                {
                    bestEatingRateSoFar = Math.Min(bestEatingRateSoFar, middle);
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }

                middle = left + (right - left) / 2;
            }

            return bestEatingRateSoFar;


        }

        public bool CanEatAllBananas(int[] piles, int eatRate, int maxEatHours)
        {
            int count = 0;

            foreach (var pile in piles)
            {
                var val = pile;
                double res = (double)val / (double)eatRate;
                var res2 = res - (int)res;
                count += res2 > 0 ? (int)res + 1 : (int)res;

                if (count > maxEatHours) 
                    return false;
            }

            return true;
        }
}
