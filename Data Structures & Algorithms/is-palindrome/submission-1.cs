public class Solution {
        public bool IsPalindrome(string s)
        {
            int p1 = 0, p2 = 0;

            s = BuildAlphanumeric(s);
            s = s.ToLower();

            if (s.Length <= 1) return true;

            if (s.Length % 2 == 0)
            {
                p1 = s.Length / 2 - 1;
                p2 = s.Length / 2;
            }
            else
            {
                p1 = s.Length / 2 - 1;
                p2 = s.Length / 2 + 1;
            }

            while (p1 >= 0 && p2 < s.Length)
            {
                if (s[p1--] != s[p2++])
                    return false;
            }

            return p1 <= 0 && p2 >= s.Length;

        }

        private string BuildAlphanumeric(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                var ch = str[i];
                bool upperLetter = 'Z' >= ch && ch >= 'A';
                bool lowerLetter = 'z' >= ch && ch >= 'a';
                bool numLetter = '9' >= ch && ch >= '0';

                if (numLetter || lowerLetter || upperLetter)
                {
                    sb.Append(ch);
                }
            }

            return sb.ToString();
        }
}
