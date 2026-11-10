public class Solution {
    private const char Delim = '_';
    private const char Esc = '\\';
    public string Encode(IList<string> strs)
    {
        var sb = new StringBuilder();

        foreach (var str in strs)
        {
            foreach (char c in str)
            {
                if (c == Esc || c == Delim)
                    sb.Append(Esc);      // prefix with escape

                sb.Append(c);
            }

            sb.Append(Delim); // terminate this string
        }

        return sb.ToString();
    }

    public List<string> Decode(string s)
    {
        var list = new List<string>();
        var sb = new StringBuilder();

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];

            if (c == Esc)
            {
                // Escaped character must exist; if input is malformed, treat '\' as literal
                if (i + 1 < s.Length)
                {
                    sb.Append(s[i + 1]);
                    i++; // skip the escaped char
                }
                else
                {
                    sb.Append(Esc);
                }
            }
            else if (c == Delim)
            {
                list.Add(sb.ToString());
                sb.Clear();
            }
            else
            {
                sb.Append(c);
            }
        }

        return list;
    }
}
