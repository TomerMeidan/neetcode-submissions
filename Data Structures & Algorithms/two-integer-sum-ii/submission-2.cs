public class Solution {
        public int[] TwoSum(int[] numbers, int target)
        {
            int left = 0, right = numbers.Length - 1;
            int[] answer = new int[2];

            Array.Sort(numbers);


            while (left < right)
            {
                if (numbers[left] + numbers[right] == target)
                {
                    answer[0] = left + 1;
                    answer[1] = right + 1;
                    return answer;
                }
                else if (numbers[left] + numbers[right] < target)
                {
                    left++;
                }
                else if (numbers[left] + numbers[right] > target)
                {
                    right--;
                }

            }


            return answer;

        }
}
