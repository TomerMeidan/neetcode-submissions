public class Solution {
    public int FindDuplicate(int[] nums) {
        HashSet<int> hash = new HashSet<int>();

        for(int i = 0 ; i < nums.Length ; i++){
            if(hash.Contains(nums[i])) 
                return nums[i];
            hash.Add(nums[i]);
        }

        return -1;
    }
}
