public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dic = new();

        for(int i = 0 ; i < nums.Length ; i++){
            if(!dic.ContainsKey(nums[i]))
              dic[nums[i]] = 0;
            dic[nums[i]]++;
        }

        var resp = dic.ToList();
        resp.Sort((a,b)=> b.Value.CompareTo(a.Value));
        int[] results = new int[k];

        for(int j = 0 ; j < k ;j++){
            results[j]=resp[j].Key;
        }
        return results;
    }
}
