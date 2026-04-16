using MathGame.Logic;

namespace MathGame.UI
{
    internal class TextGenerator
    {
        public void StartingPrompt()
        {
            Console.WriteLine("How many math problems do you want for this game?\n");
        }
        public void MenuPrompt()
        {
            Console.WriteLine("Please enter start for a new game, history to see information on your previous games, or exit to close the application\n");
        }

        public void AskUserForOperation()
        {
            Console.WriteLine("Please enter A for addition, S for subtraction, M for multiplication or  D for division\n");
        }

        public void PrintQuestion(int[] integers, Operation operation)
        {
            int a = integers[0];
            int b = integers[1];
            string equationType = operation switch
            {
                Operation.Addition => "plus",
                Operation.Subtraction => "minus",
                Operation.Multiplication => "multiplied by",
                Operation.Division => "divided by",
            };

            Console.WriteLine($"What is {a} {equationType} {b}?\n");
        }

        public void CorrectGuess(int a)
        {
            Console.Write($"Correct, the answer is {a}");
        }

        public void IncorrectGuess(int a)
        {
            Console.Write($"Sorry, the answer is not {a}");
        }

        public void Continue()
        {
            Console.WriteLine("Please enter start for a new game with the current number of problems, or exit to return to the menu\n");
        }

        public void PrintScore(int a, int b)
        {
            Console.WriteLine($" - Correct guesses {a} / {b}\n");
        }
    }
}
