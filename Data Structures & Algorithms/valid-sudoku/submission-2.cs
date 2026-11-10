public class Solution {
        public bool IsValidSudoku(char[][] board)
        {
            if (board == null) return false;

            HashSet<char>[] rows, cols, boxs;
            rows = new HashSet<char>[board.Length];
            cols = new HashSet<char>[board.Length];
            boxs = new HashSet<char>[board.Length];

            for (int i = 0; i < board.Length; i++)
            {
                rows[i] = [];
                cols[i] = [];
                boxs[i] = [];

            }

            for (int i = 0; i < board.Length; i++)
            {

                for (int j = 0; j < board[0].Length; j++)
                {
                    if (board[i][j] == '.') continue;

                    if (rows[i].Contains(board[i][j]))
                        return false;
                    else
                        rows[i].Add(board[i][j]);

                    if (cols[j].Contains(board[i][j]))
                        return false;
                    else
                        cols[j].Add(board[i][j]);

                    if (boxs[(i / 3) * 3 + (j / 3)].Contains(board[i][j]))
                        return false;
                    else
                        boxs[(i / 3) * 3 + (j / 3)].Add(board[i][j]);

                }

            }

            return true;
        }
}
