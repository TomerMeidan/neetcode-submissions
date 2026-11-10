public class Solution {
        public bool IsAnagram(string s, string t)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();

            foreach (char ch in s)
            {
                if (map.TryGetValue(ch, out int value)) 
                    map[ch] = ++value;
                else 
                    map.Add(ch, 1);
            }

            foreach(char ch in t)
            {
                if (map.TryGetValue(ch, out int value))
                {
                    map[ch] = --value;
                    if (map[ch] <= 0) 
                        map.Remove(ch);
                }
                else
                {
                    return false;
                }
            }

            return map.Count == 0;
        }
}
