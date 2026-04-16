using MathGame.Logic;

namespace MathGame.UI
{
    internal class InputParser
    {
        TextGenerator _textGenerator;

        public InputParser(TextGenerator textGenerator)
        {
            _textGenerator = textGenerator;
        }
        // Allow the user to select an operation
        public Operation GetOperationType()
        {
            while (true)
            {
                string? rawInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(rawInput))
                {
                    _textGenerator.DisplayError("Invalid input");
                    continue;
                }

                string userInput = rawInput.Trim().ToLowerInvariant();

                if (userInput == "a")
                {
                    Console.Clear();
                    return Operation.Addition;
                }

                if (userInput == "s")
                {
                    Console.Clear();
                    return Operation.Subtraction;
                }
                if (userInput == "m")
                {
                    Console.Clear();
                    return Operation.Multiplication;
                }

                if (userInput == "d")
                {
                    Console.Clear();
                    return Operation.Division;
                }

                _textGenerator.DisplayError("Invalid input");
            }

        }

        public int GetNumberFromUser()
        {
            // Return a number for the user, either as an answer or for the number of problems they want for the game
            bool guessAccepted = false;
            int result = 0;
            while (!guessAccepted)
            {
                string? userInput = Console.ReadLine();
                int userGuess;

                if (int.TryParse(userInput, out userGuess))
                {
                    guessAccepted = true;
                    result = userGuess;
                }
                else
                {
                    _textGenerator.DisplayError("Invalid input");
                }
            }
            Console.Clear();
            return result;
        }

        public bool AllowUserToContinueOrExit()
        {
            while (true)
            {
                string? rawInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(rawInput))
                {
                    _textGenerator.DisplayError("Invalid input");
                    continue;
                }

                string userInput = rawInput.Trim().ToLowerInvariant();

                if (userInput == "start")
                {
                    Console.Clear();
                    return true;
                }

                if (userInput == "exit")
                {
                    Console.Clear();
                    return false;
                }

                _textGenerator.DisplayError("Invalid input");
            }
        }

        public int GetUserMenuOption()
        {
            while (true)
            {
                string? rawInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(rawInput))
                {
                    
                    continue;
                }

                string userInput = rawInput.Trim().ToLowerInvariant();

                if (userInput == "start")
                {
                    Console.Clear();
                    return 1;
                }

                if (userInput == "history")
                {
                    Console.Clear();
                    return 2;
                }

                if (userInput == "exit")
                {
                    Console.Clear();
                    return 3;
                }

                _textGenerator.DisplayError("Invalid input");
            }
        }
    }
}
