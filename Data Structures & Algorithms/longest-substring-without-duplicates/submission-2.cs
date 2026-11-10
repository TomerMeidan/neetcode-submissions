public class Solution {
        public int LengthOfLongestSubstring(string s)
        {
            if (s == null || s == string.Empty) return 0;

            Queue<char> queue = new Queue<char>();
            HashSet<char> hash = new HashSet<char>();
            int longestSub = 0;

            for (int r = 0; r < s.Length; r++)
            {
                var currentChar = s[r];

                if (!hash.Contains(currentChar))
                {
                    hash.Add(currentChar);
                    queue.Enqueue(currentChar);
                    longestSub = Math.Max(longestSub, hash.Count);
                }
                else
                {
                    do
                    {
                        queue.TryDequeue(out char ch);
                        hash.Remove(ch);
                    } while (hash.Contains(currentChar));

                    hash.Add(currentChar);
                    queue.Enqueue(currentChar);
                }
            }

            return longestSub;


        }
}
