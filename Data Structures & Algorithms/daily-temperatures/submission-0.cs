public class Solution {
        public int[] DailyTemperatures(int[] temperatures)
        {

            Stack<(int index, int value)> monoStack = new Stack<(int index, int value)>();
            int[] result = new int[temperatures.Length];

            monoStack.Push((0, temperatures[0]));

            for (int i = 1; i < temperatures.Length;)
            {
                do
                {
                    if (monoStack.TryPeek(out (int index, int value) val))
                    {
                        if (temperatures[i] > val.value)
                        {
                            var item = monoStack.Pop();
                            result[item.index] = i - item.index;
                        }
                        else
                            break;
                    }

                } while (monoStack.Count > 0);

                monoStack.Push((i, temperatures[i]));
                i++;

            }

            return result;

        }
}
