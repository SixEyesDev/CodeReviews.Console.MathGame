using MathGame.UI;

namespace MathGame.Logic
{
    internal class EquationHandler
    {
        TextGenerator _textGenerator;

        public EquationHandler(TextGenerator textGenerator)
        {
            _textGenerator = textGenerator;
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
                Operation.Division => calculator.PerformDivision(a, b),
                _ => throw new NotImplementedException()
            };
            return result;
        }

        public bool CheckUserGuess(int a, int b)
        {
            if (a == b)
            {
                _textGenerator.CorrectGuess(a);
                return true;
            }
            else
            {
                _textGenerator.IncorrectGuess(a);
                return false;
            }
        }
    }
}
