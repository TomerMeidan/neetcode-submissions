        public class MinStack
        {
            LinkedList<(int val, int min)> list;

            public MinStack()
            {
                list = new LinkedList<(int val, int min)>();
            }

            public void Push(int val)
            {
                if (list.Count == 0)
                {
                    list.AddFirst((val,val));
                    return;
                }

                var n = list.First();
                list.AddFirst((val, n.min < val ? n.min : val));

            }

            public void Pop()
            {
                list.RemoveFirst();
            }

            public int Top()
            {
                return list.First.Value.val;
            }

            public int GetMin()
            {
                return list.First.Value.min;
            }
        }