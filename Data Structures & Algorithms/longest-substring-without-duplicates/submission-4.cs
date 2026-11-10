public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        Dictionary<char, int> window = [];
        int prefixIdx = 0;
        int max = 0, currentCount = 0;

        for (int suffixIdx = 0; suffixIdx < s.Length; suffixIdx++)
        {
            char suffixChar = s[suffixIdx];

            if (window.ContainsKey(suffixChar) == false)
            {
                window[suffixChar] = 1;
                currentCount++;
                continue;
            }

            window[suffixChar] = 2;
            max = Math.Max(max, currentCount);

            while (prefixIdx < s.Length && window[suffixChar] != 1)
            {
                char prefixChar = s[prefixIdx];
                window[prefixChar]--;
                if (window[prefixChar] == 0) 
                    window.Remove(prefixChar);
                prefixIdx++;
            }

            currentCount = window.Count();
        }

        return Math.Max(max, currentCount);

    }
}
