public class Solution {
        public List<List<string>> GroupAnagrams(string[] strs)
        {
            var list = new List<List<string>>();
            var currentList = new List<string>();
            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

            for (int i = 0; i < strs.Length; i++)
            {
                var word = strs[i];
                var wordAr = word.ToArray();

                Array.Sort(wordAr);
                string text = new string(wordAr);

                if(map.ContainsKey(text) == false)
                {
                    map.Add(text, new List<string>());
                }

                map[text].Add(strs[i]);
            }

            foreach (var item in map)
            {
                list.Add(item.Value);
            }

            return list;
        }
}
