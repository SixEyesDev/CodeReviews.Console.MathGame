using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using MathGame.UI;

namespace MathGame.Logic
{
    internal class GameEngine
    {
        TextGenerator textGenerator = new();
        InputParser inputParser = new();
        RandomNumberGenerator randomNumberGenerator = new();
        EquationHandler equationHandler;

        public GameEngine()
        {
            equationHandler = new(textGenerator);
        }
        public void Run()
        {
            int correct = 0;
            int total = 0;
          
            while (correct < 5)
            {     
                // Ask the user for their desired operation type
                textGenerator.StartingPrompt();

                // Get the users input and assign the chosen operation to a variable
                Operation operation = inputParser.GetOperationType();

                // Get two random numbers between 1 - 10 to feed into our equation
                int[] integers = randomNumberGenerator.GetRandomIntegers();

                // We return the eqauation as an array so we can supply all the data to our text generator
                int[] result = equationHandler.PerformOperation(operation, integers);

                // Send the information to the text generator to print the question in the console
                textGenerator.PrintQuestion(result, operation);

                // Get the users guess
                int userGuess = inputParser.GetUserGuess();

                // Check users guess against the correct answer, implement their score if correct
                if (equationHandler.CheckUserGuess(userGuess, result[2]))
                {
                    correct++;
                    total++;
                }
                else
                {
                    total++;
                }
                Console.Write($"  - Correct guesses {correct} / {total}\n\n");
            }
        }
    }
    public enum Operation {Addition, Subtraction, Multiplication, Division}
}
