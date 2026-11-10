public class Solution {
    public int LengthOfLongestSubstring(string s) {

        if(s.Length <= 1)
            return s.Length;

            int left = 0;
            int right = 1;
            int longestString = 0;
            Dictionary<char, int> map = new Dictionary<char, int>();

            for(right = 0 ; right < s.Length ; right++){
                if(!map.ContainsKey(s[right])){
                    map.Add(s[right], right);
                    longestString = Math.Max(longestString, map.Count);
                }else{
                    while(map.ContainsKey(s[right]))
                        map.Remove(s[left++]);
                    map.Add(s[right], right);
                }
            }

            return longestString;
    }
}
