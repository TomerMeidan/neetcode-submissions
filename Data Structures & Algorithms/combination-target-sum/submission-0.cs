public class Solution {
        public const int VALUE_RANGE = 31;

        public List<List<int>> CombinationSum(int[] nums, int target)
        {
            List<List<int>> combinations = new List<List<int>>();
            int[] values = new int[VALUE_RANGE];
            Dfs(0, nums, target, combinations, values);
            return combinations;
        }

        public void Dfs(int index, int[] nums, int target, List<List<int>> combinations, int[] values)
        {

            if (index >= nums.Length)
                return;

            if (CalculateArray(values) == target)
            {
                bool status = false;
                foreach (var list in combinations)
                {
                    status = SearchList(list, values);
                    if (status == true) break;
                }

                if (status == false)
                    combinations.Add(ArrayToList(values));

                return;

            }
            else if (CalculateArray(values) > target)
                return;

            values[nums[index]]++;
            Dfs(index, nums, target, combinations, values);
            values[nums[index]]--;
            Dfs(index + 1, nums, target, combinations, values);

        }

        public List<int> ArrayToList(int[] array)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < VALUE_RANGE; i++)
            {
                var amount = array[i];
                while(amount > 0){
                    list.Add(i);
                    amount--;
                }
            }
            return list;
        }

        public bool SearchList(List<int> list, int[] array)
        {
            int[] nums = array.ToArray();

            for (int i = 0; i < list.Count; i++)
            {
                nums[list[i]]--;
            }

            for (int i = 0; i < VALUE_RANGE; i++)
            {
                var value = array[i];
                if (value > 0 || value < 0) return false;
            }

            return true;
        }
        public int CalculateArray(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < VALUE_RANGE; i++)
            {
                sum += array[i] * i;        
            }
            return sum;
        }
}
