public class Solution {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] prodArr = new int[nums.Length];
            int sum = 1;
            int k = 0;
            bool hasZero = false;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0 && hasZero == false)
                {
                    hasZero = true;
                }
                else if (nums[i] == 0 && hasZero == true)
                {
                    return prodArr;
                }
                else
                {
                    sum *= nums[i];
                }
            }



            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    if (hasZero)
                        prodArr[k++] = 0;
                    else
                        prodArr[k++] = sum / nums[i];
                }
                else
                {
                    prodArr[k++] = sum;
                }

            }

            return prodArr;
        }
}
