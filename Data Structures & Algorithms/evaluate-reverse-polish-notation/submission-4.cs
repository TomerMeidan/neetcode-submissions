public class Solution {
        public int EvalRPN(string[] tokens)
        {
            if (tokens.Length == 1) return int.Parse(tokens[0]);
            Stack<int> tokStack = new Stack<int>();
            int first = 0;
            int second = 0;
            int sum = 0;

            for (int i = 0; i < tokens.Length; i++)
            {

                while (i < tokens.Length && IsNotOperand(tokens[i]))
                {
                    tokStack.Push(int.Parse(tokens[i++]));
                }

                string operand = tokens[i];

                if (tokStack.Count > 1)
                {
                    second = tokStack.Pop();
                    first = tokStack.Pop();

                    sum = OperandAction(first, second, operand);
                    tokStack.Push(sum);
                }

            }
            return sum;
        }

        public bool IsNotOperand(string op)
        {
            var status = op != "+" && op != "-" && op != "*" && op != "/";
            return status;
        }

        public int OperandAction(int number1, int number2, string operand)
        {

            if (operand == "+") return number1 + number2;
            if (operand == "-") return number1 - number2;
            if (operand == "*") return number1 * number2;
            if (operand == "/")
            {
                if (number2 == 0) return 0;
                return number1 / number2;
            }

            return -1;
        }
}
