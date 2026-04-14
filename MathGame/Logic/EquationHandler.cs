using System;
using System.Collections.Generic;
using System.Text;
using MathGame.UI;

namespace MathGame.Logic
{
    internal class EquationHandler
    {
        TextGenerator textGenerator1;

        public EquationHandler(TextGenerator textGenerator)
        {
            textGenerator1 = textGenerator;
        }

        Calculator calculator = new();
        public int[] PerformOperation(Operation operation, int[] integers)
        {
            int a = integers[0];
            int b = integers[1];

            int[] result = operation switch
            {
                Operation.Addition => calculator.PerformAddition(a, b),
                Operation.Subtraction => calculator.PerformSubtraction(a, b),
                Operation.Multiplication => calculator.PerformMultiplication(a, b),
                Operation.Division => calculator.PerformDivision(a, b)
            };

            return result;
        }

        public bool CheckUserGuess(int a, int b)
        {
            if (a == b)
            {
                textGenerator1.CorrectGuess(a);
                return true;
            }
            else
            {
                textGenerator1.IncorrectGuess(a);
                return false;
            }
        }
    }
}
