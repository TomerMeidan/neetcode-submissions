public class Solution {
        public int[] TwoSum(int[] numbers, int target) {
            Dictionary<int,int> map = new Dictionary<int, int>();

            int[] array = new int[2];
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (map.ContainsKey(target - numbers[i]))
                {
                    array[0] = map[target - numbers[i]] + 1;
                    array[1] = i + 1;
                    return array;
                }
                map.Add(numbers[i], i);
            }

            return array;
        }
}
