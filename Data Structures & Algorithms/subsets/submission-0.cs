public class Solution {

    public List<List<int>> Subsets(int[] nums) {
        var res = new List<List<int>>();
        var subset = new List<int>();
        Dfs(0, nums, subset, res);
        return res;


    }

    public void Dfs(int index, int[] nums, List<int> subset, List<List<int>> res){

        if(index >= nums.Length){
            res.Add(new List<int>(subset));
            return;
        }

        subset.Add(nums[index]);
        Dfs(index + 1, nums, subset, res);
        subset.RemoveAt(subset.Count -1);
        Dfs(index + 1, nums, subset, res);
    }
}
