public class Solution {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] prodArr = new int[nums.Length];
            int sum = 1;
            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if(i != j)
                    {
                        sum *= nums[j];
                    }
                }

                prodArr[k++] = sum;
                sum = 1;
            }

            return prodArr;
        }
}
