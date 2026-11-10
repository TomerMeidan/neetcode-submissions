public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
            int left = 0;
            int right = numbers.Length - 1;
            int[] answer = new int[2];

            while (left < right)
            {
                int middle = numbers[right] + numbers[left];

                if (target == middle)
                {
                    answer[0] = left + 1;
                    answer[1] = right + 1;
                    return answer;
                }

                if (target < middle)
                    right--;
                else
                    left++;
            }

            return answer;
    }
}
