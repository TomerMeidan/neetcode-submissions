public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        int[] kthMax = new int[k];

        for (int i = 0; i < nums.Length; i++)
        {
            if (!map.ContainsKey(nums[i]))
                map[nums[i]] = 0;
            map[nums[i]]++;
        }


        for (int j = 0; j < k; j++)
        {
            int index = 0;
            int maxCount = 0;

            foreach (var item in map)
            {
                if (maxCount < item.Value)
                {
                    maxCount = item.Value;
                    index = item.Key;
                }
            }

            map.Remove(index);
            kthMax[j] = index;
        }

        return kthMax;

    }
}
