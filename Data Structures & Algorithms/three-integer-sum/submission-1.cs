public class Solution {
        public List<List<int>> ThreeSum(int[] nums)
        {
            int left, middle, right;
            HashSet<(int,int,int)> hash = new HashSet<(int,int,int)>();
            List<List<int>> list = new List<List<int>>();

            Array.Sort(nums);

            for (left = 0; left < nums.Length; left++)
            {

                for (right = nums.Length - 1; right > left; right--)
                {
                    middle = right - 1;

                    while (middle > left && middle < right)
                    {
                        int val = nums[left] + nums[middle] + nums[right];

                        if (val == 0)
                        {
                            if(!hash.Contains((nums[left], nums[middle], nums[right])))
                            {
                                hash.Add((nums[left], nums[middle], nums[right]));
                                list.Add([nums[left], nums[middle], nums[right]]);
                            }
                        }

                        middle--;

                    }
                }

            }

            return list;
        }
}
