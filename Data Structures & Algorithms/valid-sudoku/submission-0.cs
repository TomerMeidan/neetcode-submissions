public class Solution {
        public bool IsValidSudoku(char[][] board)
        {
            Dictionary<int, HashSet<char>> rows = new Dictionary<int, HashSet<char>>();
            Dictionary<int, HashSet<char>> cols = new Dictionary<int, HashSet<char>>();
            HashSet<char>[][] boxs = new HashSet<char>[3][];


            for (int i = 0; i < 9; i++)
            {
                rows.Add(i, new HashSet<char>());
                cols.Add(i, new HashSet<char>());
                boxs[i % 3] = new HashSet<char>[3];
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    boxs[i][j] = new HashSet<char>();
                }
            }

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    var ch = board[i][j];
                    if (ch  == '.') 
                        continue;

                    if (rows[i].Contains(ch)) 
                        return false;
                    rows[i].Add(ch);

                    if (cols[j].Contains(ch))
                        return false;
                    cols[j].Add(ch);

                    if (boxs[i / 3][j / 3].Contains(ch))
                        return false;
                    boxs[i / 3][j / 3].Add(ch);
                }
            }

            return true;
        }

}
