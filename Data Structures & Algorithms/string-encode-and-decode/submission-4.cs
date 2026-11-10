public class Solution {

 public string Encode(IList<string> strs)
 {
     if (strs == null) return string.Empty;

     int charNumber = 0;
     StringBuilder sb = new StringBuilder();

     foreach(string str in strs)
     {
         foreach (char c in str)
         {
             charNumber++;
         }

         sb.Append($"{charNumber}#{str}");
         charNumber = 0;
     }

     return sb.ToString();
 }

 public List<string> Decode(string s)
 {
     var list = new List<string>();
     string number = "0";
     int wordLen = 0;
     StringBuilder currentWord = new StringBuilder();

     if(s == null) return list;

     for (int i = 0; i < s.Length; i++)
     {

         if (s[i] != '#')
             number += s[i];
         else if (s[i] == '#')
         {
             wordLen = int.Parse(number);
             int j = 0;

             while (j < wordLen && i < s.Length)
             {
                 currentWord.Append(s[++i]);
                 j++;
             }

             list.Add(currentWord.ToString());
             currentWord.Clear();
             number = string.Empty;
         }
     }

     return list;

 }
}
