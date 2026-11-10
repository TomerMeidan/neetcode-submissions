public class Solution {
        public List<List<int>> ThreeSum(int[] nums)
        {

            List<List<int>> threeSumList = new List<List<int>>();
            HashSet<(int, int, int)> hash = new HashSet<(int, int, int)>();

            int p1 = 0, p2 = 0;

            Array.Sort(nums);

            if (nums == null || nums.Length < 3) return threeSumList;

            for (int i = 0; i < nums.Length - 2; i++)
            {
                p1 = i + 1;
                p2 = nums.Length - 1;

                while (p1 < p2)
                {
                    var sum = nums[i] + nums[p1] + nums[p2];

                    if (sum < 0)
                    {
                        if (p1 <= p2) p1++;
                        else p2--;
                    }
                    else if (sum > 0)
                    {
                        if (p1 <= p2) p2--;
                        else p1++;
                    }
                    else if (sum == 0)
                    {
                        if(!hash.Contains((nums[i], nums[p1], nums[p2])))
                        {
                            threeSumList.Add([nums[i], nums[p1], nums[p2]]);
                            hash.Add((nums[i], nums[p1], nums[p2]));
                        }
                        p1++;
                        p2--;
                    }
                }
            }

            return threeSumList;

        }
}
