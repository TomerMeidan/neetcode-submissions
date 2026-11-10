public class Solution {

        private const char wordLengthIndicator = '#';
        public string Encode(IList<string> strs)
        {
            StringBuilder entireSb = new StringBuilder();
            StringBuilder wordSb = new StringBuilder();
            int count = 0;
            foreach (var word in strs)
            {

                for (int i = 0; i < word.Length; i++)
                {
                    var ch = word[i];
                    wordSb.Append(ch);
                    count++;
                }

                entireSb.Append($"{count}{wordLengthIndicator}{wordSb.ToString()}");
                wordSb.Clear();
                count = 0;
            }

            return entireSb.ToString();
        }

        public List<string> Decode(string s)
        {
            StringBuilder wordSb = new StringBuilder();
            List<string> wordList = new List<string>();
            int i = 0, j = 0;

            for (i = 0; i < s.Length; i++)
            {

                while (s[i] != wordLengthIndicator)
                {
                    wordSb.Append(s[i++]);
                }

                if (int.TryParse(wordSb.ToString(), out int result))
                {
                    wordSb.Clear();
                    for (j = i + 1; j < i + result + 1; j++)
                    {
                        wordSb.Append(s[j]);
                    }
                }
                else
                {
                    return null;
                }

                wordList.Add(wordSb.ToString());
                wordSb.Clear();
                i = j - 1;
            }

            return wordList;
        }
}
