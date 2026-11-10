public class Solution {
        public int NumIslands(char[][] grid)
        {

            if (grid.Length == 0) return 0;
            Stack<(char ch, int i, int j)> stack = new Stack<(char n, int i, int j)>();
            int count = 0;
            for (int i = 0; i < grid.Length; i++)
            {

                for (int j = 0; j < grid[0].Length; j++)
                {

                    if (grid[i][j] == '1')
                    {
                        count++;
                        stack.Push((grid[i][j], i, j));
                    

                        while (stack.Count > 0)
                        {
                            var node = stack.Pop();

                            grid[node.i][node.j] = '2';

                            if (node.i > 0 && grid[node.i - 1][node.j] == '1')
                                stack.Push((grid[node.i - 1][node.j], node.i - 1, node.j));

                            if (node.i < grid.Length - 1 && grid[node.i + 1][node.j] == '1')
                                stack.Push((grid[node.i + 1][node.j], node.i + 1, node.j));

                            if (node.j > 0 && grid[node.i][node.j - 1] == '1')
                                stack.Push((grid[node.i][node.j - 1], node.i, node.j - 1));

                            if (node.j < grid[0].Length - 1 && grid[node.i][node.j + 1] == '1')
                                stack.Push((grid[node.i][node.j + 1], node.i, node.j + 1));
                        }
                    }

                }
            }

            return count;

        }
}
