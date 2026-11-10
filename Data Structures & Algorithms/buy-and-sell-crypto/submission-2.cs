public class Solution {
    public int MaxProfit(int[] prices) {

        if(prices.Length < 2) return 0;

        int smallestValue = prices[0];
        int max = 0;

        for(int i = 1 ; i < prices.Length ; i++){          
            if(prices[i] > smallestValue){
                max = Math.Max(max, prices[i] - smallestValue);
            }else{ 
                smallestValue = prices[i];
            } 
        }

        return max;

    }
}
