public class Solution {
        public bool CheckInclusion(string s1, string s2)
        {
            if (s1 == null || s2 == null) return false;
            if (s1.Length == 0 || s2.Length == 0) return false;

            Dictionary<char, int> need = new Dictionary<char, int>();
            Dictionary<char, int> have = new Dictionary<char, int>();

            for (int i = 0; i < s1.Length; i++)
            {
                if (need.ContainsKey(s1[i]))
                    need[s1[i]]++;
                else
                    need.Add(s1[i], 1);
            }

            int same = need.Count;
            int current = 0;
            int left = 0;
            for (int i = 0; i < s2.Length; i++)
            {

                if (need.ContainsKey(s2[i]))
                {
                    if (have.ContainsKey(s2[i]))
                        have[s2[i]]++;
                    else
                        have.Add(s2[i], 1);

                    if (current == 0) left = i;

                    if (have[s2[i]] == need[s2[i]])
                    {
                        current++;
                        if (same == current)
                            return true;

                    }

                    while (left < i && have[s2[i]] > need[s2[i]])
                    {
                        have[s2[left]]--;
                        if (have[s2[left]] < need[s2[left]])
                            current--;
                        left++;
                    }
                }
                else
                {
                    current = 0;
                    have.Clear();
                }
            }

            return false;
        }
}
