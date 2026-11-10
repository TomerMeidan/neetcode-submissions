public class Solution {
        public int[][] KClosest(int[][] points, int k)
        {
            PriorityQueue<(int x, int y), double> q = new(comparer: Comparer<double>.Create((a, b) => b.CompareTo(a)));

            for (int i = 0; i < points.Length; i++)
            {
                var res = Distance(points[i][0], points[i][1]);
                q.Enqueue((points[i][0], points[i][1]), res);

                if (q.Count > k)
                {
                    q.Dequeue();
                }
            }


            if (q.Count == 0) return [];

            int[][] array = new int[q.Count][];

            for (int i = 0; i < array.Length; i++)
            {
                
                var res = q.Dequeue();
                array[i] = new int[] { res.x, res.y };
            }

            return array;
        }

        public double Distance(int x, int y)
        {
            return Math.Pow(x, 2) + Math.Pow(y, 2);
        }
}
