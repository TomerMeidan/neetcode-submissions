public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        
        if(nums == null) return new int[0];

        int[] products = new int[nums.Length];
        int sum = 1, zeroCounter = 0;

        for(int i = 0 ; i < nums.Length ; i++){
            if(nums[i] == 0){
                zeroCounter++;
            }else{
                sum *= nums[i];
            }
        }

        if(zeroCounter > 1) return products;

        for(int j = 0 ; j < nums.Length; j++){

            if(zeroCounter > 0){
                if(nums[j] == 0){
                    products[j] = sum;
                }else{
                    products[j] = 0;
                }
                
            }else{
                products[j] = sum / nums[j];
            }
             
        }

        return products;
    }
}
