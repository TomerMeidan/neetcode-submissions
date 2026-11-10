public class Solution {
        public int CharacterReplacement(string s, int k)
        {
            Dictionary<char, int> dic = new();
            int prefix = 0;
            int maxLength = 0;
            int maxFreq = 0;

            for (int suffix = 0; suffix < s.Length; suffix++)
            {
                char letter = s[suffix];

                if (!dic.ContainsKey(letter))
                {
                    dic[letter] = 0;
                }
                dic[letter]++;

                maxFreq = Math.Max(maxFreq, dic[letter]);

                if ((suffix - prefix + 1) - maxFreq <= k)
                {
                    maxLength++;
                }
                else
                {
                    if (dic[s[prefix]] > 0)
                        dic[s[prefix]]--;

                    if(prefix + 1 < s.Length)
                        prefix++;
                }
            }

            return maxLength;

        }
}
