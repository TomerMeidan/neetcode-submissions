public class Solution {
    public bool IsAnagram(string s, string t)
    {

        if (s.Length != t.Length) return false;
        Dictionary<char, int> dic1 = new();
        Dictionary<char, int> dic2 = new();

        for (int i = 0; i < s.Length; i++)
        {
            if (!dic1.ContainsKey(s[i]))
                dic1[s[i]] = 0;

            if (!dic2.ContainsKey(t[i]))
                dic2[t[i]] = 0;

            dic1[s[i]]++;
            dic2[t[i]]++;
        }

        foreach (var val in dic1)
        {
            if (!dic2.ContainsKey(val.Key))
                return false;

            if (dic2[val.Key] != val.Value)
                return false;
        }

        return true;
    }
}
