public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> map = new Dictionary<int,int>();
        int[] array = new int[2];

        for(int i = 0 ; i < nums.Length; i++){
            if(map.ContainsKey(target - nums[i])){
                array[1] = i;
                array[0] = map[target - nums[i]];
                return array;
            }else{
                map.TryAdd(nums[i], i);
            }
        }

        return array;
    }
}
