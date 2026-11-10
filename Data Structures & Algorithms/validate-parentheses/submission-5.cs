public class Solution {
        public bool IsValid(string s)
        {

            if (s == null || s.Length <= 1 || s.Length % 2 != 0)
                return false;

            Stack<char> left = new Stack<char>();

            for (int i = 0; i < s.Length;)
            {
                if (s[i] != '{' && s[i] != '[' && s[i] != '(')
                    return false;

                while (i < s.Length && (s[i] == '{' || s[i] == '[' || s[i] == '('))
                {
                    left.Push(s[i]);
                    i++;
                }

                if (i >= s.Length)
                    return false;

                while (left.Count > 0)
                {
                    var ch = left.Pop();

                    if (i >= s.Length)
                        return false;

                    if (ch == '[')
                        if (s[i] != ']')
                            return false;

                    if (ch == '(')
                        if (s[i] != ')')
                            return false;

                    if (ch == '{')
                        if (s[i] != '}')
                            return false;
                    i++;
                }
            }

            return true;
        }
}
