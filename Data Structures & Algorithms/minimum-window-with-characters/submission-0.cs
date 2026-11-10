public class Solution {
public string MinWindow(string s, string t)
{
    if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t)) return "";

    Dictionary<char, int> countT = new Dictionary<char, int>();
    foreach (char c in t)
    {
        if (countT.ContainsKey(c)) countT[c]++;
        else countT[c] = 1;
    }

    Dictionary<char, int> countS = new Dictionary<char, int>();
    int need = countT.Count;
    int have = 0;
    
    // Track the best window found
    int minLen = int.MaxValue;
    int startIndex = 0;

    int left = 0;
    for (int right = 0; right < s.Length; right++)
    {
        char c = s[right];
        
        // 1. Expand: Add character at 'right' to current window
        if (countS.ContainsKey(c)) countS[c]++;
        else countS[c] = 1;

        // Check if this character completes a requirement for 't'
        if (countT.ContainsKey(c) && countS[c] == countT[c])
        {
            have++;
        }

        // 2. Shrink: While the window is valid, try to make it smaller
        while (have == need)
        {
            // Update the result if this window is smaller than what we've seen
            if (right - left + 1 < minLen)
            {
                minLen = right - left + 1;
                startIndex = left;
            }

            // Remove the character at 'left' from the window
            char leftChar = s[left];
            countS[leftChar]--;
            
            // If removing this character breaks the "valid window" condition
            if (countT.ContainsKey(leftChar) && countS[leftChar] < countT[leftChar])
            {
                have--;
            }
            
            left++;
        }
    }

    return minLen == int.MaxValue ? "" : s.Substring(startIndex, minLen);
}
}
