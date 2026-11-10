public class Solution {
public int[] TopKFrequent(int[] nums, int k)
{
    Dictionary<int, int> map = new Dictionary<int, int>();
    int[] kthMax = new int[k];
    PriorityQueue<int, int> q = new PriorityQueue<int, int>(comparer: Comparer<int>.Create((a, b) => b.CompareTo(a)));

    for (int i = 0; i < nums.Length; i++)
    {
        if (!map.ContainsKey(nums[i]))
            map[nums[i]] = 0;
        map[nums[i]]++;
    }

    foreach (var item in map)
    {
        q.Enqueue(item.Key, item.Value);
    }
    int count = 0;

    while(q.Count > 0 && count < k)
    {
        kthMax[count++] = q.Dequeue();
    }

    return kthMax;

}
}
