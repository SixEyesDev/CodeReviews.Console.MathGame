using System;
using System.Collections.Generic;
using System.Text;

namespace MathGame.Logic
{
    internal class Calculator
    {
        int[] equation = new int[3];

        public int[] PerformAddition(int a, int b)
        {
            int result = a + b;
            equation[0] = a;
            equation[1] = b;
            equation[2] = result;
            return equation;
        }

        public int[] PerformSubtraction(int a, int b)
        {
            int result = 0;
            if (a > b || a == b)
            {
                result = a - b;
                equation[0] = a;
                equation[1] = b;
                equation[2] = result;
                return equation;
            }
    
            else
            {
                result = b - a;
                equation[0] = b;
                equation[1] = a;
                equation[2] = result;
                return equation;
            }
        }

        public int[] PerformMultiplication(int a, int b)
        {
            int result = a * b;
            equation[0] = a;
            equation[1] = b;
            equation[2] = result;
            return equation;
        }

        public int[] PerformDivision(int a, int b)
        {
            // For division we multiply the two integers to get our dividend to ensure the answer is a whole number
            // We then use the first integer as the divisor

            int result = a * b;
            equation[0] = result;
            equation[1] = a;
            equation[2] = b;
            return equation;
        }
    }
}
