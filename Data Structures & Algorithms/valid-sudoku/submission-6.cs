public class Solution {
    public bool IsValidSudoku(char[][] board) {
        
        Dictionary<int, HashSet<char>> rows = new();
        Dictionary<int, HashSet<char>> cols = new();
        Dictionary<(int, int), HashSet<char>> subBoxes = new();

        for(int i = 0 ; i < board[0].Length ; i++){

            if(!rows.ContainsKey(i))
                rows[i] = new();

            for(int j = 0 ; j < board[0].Length ; j++){

                if(!cols.ContainsKey(j))
                    cols[j] = new();

                var item = board[i][j];

                if(item == '.') continue;

                // Rows Check
                if(rows[i].Contains(item)) 
                    return false;
                rows[i].Add(item);

                // Cols Check
                if(cols[j].Contains(item))
                    return false;
                cols[j].Add(item);

                // Square Check
                int adRow = i / 3;
                int adCol = j / 3;
               
                if(!subBoxes.ContainsKey((adRow, adCol)))
                    subBoxes[(adRow, adCol)] = new();

                if(subBoxes[(adRow,adCol)].Contains(item))
                    return false;
                subBoxes[(adRow,adCol)].Add(item);
       
            }
        }

        return true;

    }
}
