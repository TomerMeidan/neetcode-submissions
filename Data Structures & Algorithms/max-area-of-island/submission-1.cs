public class Solution {
        public int MaxAreaOfIsland(int[][] grid)
        {

            if (grid.Length == 0) return 0;
            Stack<(int ch, int i, int j)> stack = new Stack<(int n, int i, int j)>();
            int maxArea = 0;
            for (int i = 0; i < grid.Length; i++)
            {

                for (int j = 0; j < grid[0].Length; j++)
                {

                    if (grid[i][j] == 1)
                    {
                        int currentArea = 1;                                                        
                        stack.Push((grid[i][j], i, j));
                        
                        while (stack.Count > 0)
                        {
                            var n = stack.Pop();
                            grid[n.i][n.j] = 2;

                            if (n.i > 0 && grid[n.i - 1][n.j] == 1)
                            {
                                currentArea++;
                                grid[n.i - 1][n.j] = 2;
                                stack.Push((grid[n.i - 1][n.j], n.i - 1, n.j));
                            }

                            if (n.i < grid.Length - 1 && grid[n.i + 1][n.j] == 1)
                            {
                                currentArea++;
                                grid[n.i + 1][n.j] = 2;
                                stack.Push((grid[n.i + 1][n.j], n.i + 1, n.j));
                            }

                            if (n.j > 0 && grid[n.i][n.j - 1] == 1)
                            {
                                currentArea++;
                                grid[n.i][n.j - 1] = 2;
                                stack.Push((grid[n.i][n.j - 1], n.i, n.j - 1));
                            }

                            if (n.j < grid[0].Length - 1 && grid[n.i][n.j + 1] == 1)
                            {
                                currentArea++;
                                grid[n.i][n.j + 1] = 2;
                                stack.Push((grid[n.i][n.j + 1], n.i, n.j + 1));
                            }
                        }

                        maxArea = Math.Max(currentArea, maxArea);
                    }

                }
            }

            return maxArea;

        }
}
