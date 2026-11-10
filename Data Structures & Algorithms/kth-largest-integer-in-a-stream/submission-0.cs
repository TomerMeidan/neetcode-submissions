public class KthLargest {

    private PriorityQueue<int, int> _q;
    private int _k; 
    private Stack<int> _temp;

    public KthLargest(int k, int[] nums) {
        _q = new PriorityQueue<int, int>(comparer: Comparer<int>.Create((a,b) => b.CompareTo(a)));
        _temp = new Stack<int>();

        _k = k;

        for(int i = 0 ; i < nums.Length ; i++){
            _q.Enqueue(nums[i], nums[i]);
        }

    }

            public int Add(int val)
            {
                _q.Enqueue(val, val);
                int i = 0;

                while (_q.Count > 0 && i < _k)
                {
                    _temp.Push(_q.Dequeue());
                    i++;
                }
                var res = _temp.Peek();

                while (_temp.Count > 0)
                {
                    var v = _temp.Pop();
                    _q.Enqueue(v, v);
                }

                return res;
            }
}
