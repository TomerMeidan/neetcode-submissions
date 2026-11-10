public class Solution {
        public List<List<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
            int[] letterIndex = new int[26];

            for (int i = 0; i < strs.Length; i++)
            {
                var word = strs[i];
                letterIndex = new int[26];

                for (int j = 0; j < word.Length; j++)
                {
                    letterIndex[word[j] - 'a']++;
                }

                var joinWord = string.Join(',', letterIndex);

                if(!map.ContainsKey(joinWord))
                {
                    map.Add(joinWord, new List<string>());
                }

                map[joinWord].Add(word);

            }

            return map.Values.ToList();

        }
}
