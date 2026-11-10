public class Solution {
        public bool IsPalindrome(string s)
        {
            if (s.Length <= 1) return true;

            s = s.ToLower();
            int left = 0;
            int right = s.Length - 1;

            while (right > 0 && ('z' < s[right] || s[right] < 'a') && ('9' < s[right] || s[right] < '0'))
            {
                right--;
            }

            while (left < right && ('z' < s[left] || s[left] < 'a') && ('9' < s[left] || s[left] <'0'))
            {
                left++;
            }

            int size = right - left + 1;

            while (left < right)
            {
                while (left < size && ('z' < s[left] || s[left] < 'a') && ('9' < s[left] || s[left] < '0'))
                {
                    left++;
                }

                while (right >= 0 && ('z' < s[right] || s[right] < 'a') && ('9' < s[right] || s[right] < '0'))
                {
                    right--;
                }
                var leftCh = s[left];
                var rightCh = s[right];

                if (leftCh != rightCh) return false;

                left++;
                right--;
            }

            return true;

        }
}
