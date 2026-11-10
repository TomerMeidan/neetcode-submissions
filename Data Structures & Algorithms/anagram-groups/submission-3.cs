public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
        int[] indexCharArray = new int[256];

        foreach(var word in strs){
            indexCharArray = new int[256];

            for(int i = 0 ; i < word.Length; i++){
                indexCharArray[word[i]]++;
            }

            string serializedWord = string.Join(',', indexCharArray);

            if(!map.ContainsKey(serializedWord))
                map[serializedWord] = new List<string>();
            map[serializedWord].Add(word);

        }

        List<List<string>> list = new  List<List<string>>();
        foreach(var item in map.Values){
            list.Add(item);
        }
        return list;
    }
}
