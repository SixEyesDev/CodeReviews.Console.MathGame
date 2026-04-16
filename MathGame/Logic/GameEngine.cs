using MathGame.UI;

namespace MathGame.Logic
{
    internal class GameEngine
    {

        InputParser _inputParser = new();
        RandomNumberGenerator _randomNumberGenerator = new();
        EquationHandler _equationHandler;
        TextGenerator _textGenerator;


        public GameEngine(TextGenerator textGenerator)
        {
            _textGenerator = textGenerator;
            _equationHandler = new(textGenerator);
        }

        public List<GameData> Run(List<GameData> gameList, int totalQuestions)
        {
            bool gameOver = false;

            while (!gameOver)
            {
                int correct = 0;
                int total = 0;

                while (total < totalQuestions)
                {
                    // Ask the user for their desired operation type
                    _textGenerator.AskUserForOperation();

                    // Get the users input and assign the chosen operation to a variable
                    Operation operation = _inputParser.GetOperationType();

                    // Get two random numbers between 1 - 10 to feed into our equation
                    int[] integers = _randomNumberGenerator.GetRandomIntegers();

                    // We return the eqauation as an array so we can supply all the data to our text generator
                    int[] result = _equationHandler.PerformOperation(operation, integers);

                    // Send the information to the text generator to print the question to the console
                    _textGenerator.PrintQuestion(result, operation);

                    // Get the users guess
                    int userGuess = _inputParser.GetNumberFromUser();

                    // Check users guess against the correct answer, implement their score if correct
                    if (_equationHandler.CheckUserGuess(userGuess, result[2]))
                    {
                        correct++;
                        total++;
                    }
                    else
                    {
                        total++;
                    }
                    _textGenerator.PrintScore(correct, total);
                }

                GameData gameData = new(correct, total);
                gameList.Add(gameData);

                _textGenerator.Continue();

                if (_inputParser.AllowUserToContinueOrExit())
                {
                    gameOver = false;
                }
                else
                {
                    gameOver = true;
                }
            }

            return gameList;
        }
    }
    public enum Operation { Addition, Subtraction, Multiplication, Division }
}
