public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> hs = new();

        for(int i = 0 ; i < nums.Length ; i++){
            if(!hs.Contains(nums[i])){
                hs.Add(nums[i]);
            }else
                return true;
        }

        return false;
    }
}