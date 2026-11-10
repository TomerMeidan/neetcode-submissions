public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        //int minValue = int.MaxValue;
        int left = 0, right = 1;
        while(right < prices.Length){
            if(prices[left] < prices[right]){
                maxProfit = Math.Max(maxProfit, prices[right] - prices[left]);
            }else{
                left = right;
            }
            right++;
        }

        return maxProfit;
    }
}
