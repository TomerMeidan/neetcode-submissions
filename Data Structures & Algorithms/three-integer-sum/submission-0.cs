public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
            List<List<int>> list = new List<List<int>>();
            Array.Sort(nums);
            HashSet<(int, int, int)> hash = new HashSet<(int, int, int)>();

            for (int i = 0; i < nums.Length; i++)
            {
                int middle = i;
                int left = middle + 1;
                int right = nums.Length - 1;

                while (left < right)
                {

                    if (nums[left] + nums[middle] + nums[right] > 0) // Value is too high, need less positive
                    {
                        right--;
                    }
                    else if (nums[left] + nums[middle] + nums[right] < 0)// Value is too low, need less negative
                    {
                        left++;
                    }
                    else if (nums[left] + nums[middle] + nums[right] == 0)// This is just right
                    {

                        if (!hash.Contains((nums[left], nums[middle], nums[right])))
                        {
                            hash.Add((nums[left], nums[middle], nums[right]));
                            list.Add(new List<int>([nums[left], nums[middle], nums[right]]));
                        }

                        if (left < nums.Length - 1) left++;
                        else if (right > 0) right--;

                    }


                }
            }

            return list;
    }
}
