public class Solution {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] prodArr = new int[nums.Length];
            int[] sumArr = new int[nums.Length];
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
                    sumArr[i] = sum;
                }
            }

            int p2 = nums.Length - 1;
            int p1 = nums.Length - 2;
            int mult = 1;

            while (p1 >= 0)
            {

                if (nums[p2] != 0)
                {
                    if(hasZero)
                        prodArr[p2] = 0;
                    else
                    {
                        prodArr[p2] = sumArr[p1] * mult;
                    }
                }
                else
                {
                    prodArr[p2] = sum;
                }

                mult *= nums[p2];
                p2--;
                p1--;
            }

            prodArr[0] = mult;

            return prodArr;
        }
}
