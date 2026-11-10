public class Solution {

        public string Encode(IList<string> strs)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var str in strs)
            {
                if (str.Length == 0)
                {
                    sb.Append('e');
                }
                else
                {
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str[i] == '_' || str[i] == 'e')
                        {
                            sb.Append(str[i]);
                        }  
                        sb.Append(str[i]);
                    }

                }

                sb.Append('_');
            }

            return sb.ToString();
        }

        public List<string> Decode(string s)
        {
            List<string> list = new List<string>();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {

                switch (s[i])
                {
                    case '_':

                        if (i < s.Length - 1 && s[i + 1] == '_')
                        {
                            sb.Append(s[i++]);
                        }
                        else
                        {
                            list.Add(sb.ToString());
                            sb = new StringBuilder();
                        }

                        break;
                    case 'e':
                        if (i < s.Length - 1 && s[i + 1] == 'e')
                        {
                            sb.Append(s[i++]);
                        }
                        else
                        {
                            sb = new StringBuilder();
                        }
                        break;

                    default:
                        sb.Append(s[i]);
                        break;
                }



            }

            return list;
        }
}
