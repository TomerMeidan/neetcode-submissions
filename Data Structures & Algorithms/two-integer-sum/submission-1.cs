public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> dic = new();

        for(int i = 0 ; i < nums.Length ; i++){
            if(dic.ContainsKey(target - nums[i]))
            return new int[]{dic[target - nums[i]], i};
            dic[nums[i]] = i;
        }
        return [];
    }
}
