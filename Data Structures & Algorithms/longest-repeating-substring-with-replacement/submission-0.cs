public class Solution {
        public int CharacterReplacement(string s, int k)
        {
            int left = 0, right = 0;
            Dictionary<char, int> map = new Dictionary<char, int>(26);
            int currentMaxFreq = 0;
            int result = 0;

            while (right < s.Length)
            {
                if (!map.ContainsKey(s[right]))
                    map.Add(s[right], 0);           
                
                map[s[right]]++;

                foreach (var ch in map)
                {
                    currentMaxFreq = Math.Max(ch.Value, currentMaxFreq);
                }

                int windowLength = right - left + 1;

                if (windowLength - currentMaxFreq <= k)
                {
                    result++;
                }
                else
                {
                    map[s[left++]]--;
                }

                right++;

            }

            return result;
        }
}
