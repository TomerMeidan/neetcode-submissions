public class Solution {
        public List<List<int>> ThreeSum(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            int middle = nums.Length - 2;

            List<List<int>> list = new List<List<int>>();
            HashSet<(int, int, int)> hash = new HashSet<(int, int, int)>();

            Array.Sort(nums);

            for (left = 0;  left < nums.Length - 1; left++)
            {
                middle = left + 1;
                right = nums.Length - 1;

                while(right > middle)
                {
                    int sum = nums[left] + nums[middle] + nums[right];

                    if(sum == 0)
                    {
                        if(!hash.Contains((nums[left], nums[middle], nums[right]))){
                            list.Add([nums[left], nums[middle], nums[right]]);
                            hash.Add((nums[left], nums[middle], nums[right]));
                        }
                        middle++;
                        right--;

                    }if(sum < 0)
                    {
                        middle++;
                    }if(sum > 0)
                    {
                        right--;
                    }

                }
            }

            return list;
        }
}
