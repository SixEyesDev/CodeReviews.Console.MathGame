using System;
using System.Collections.Generic;
using System.Text;
using MathGame.Logic;

namespace MathGame.UI
{
    internal class InputParser
    {
        // Allow the user to select an operation
        public Operation GetOperationType()
        {
            Operation operation;

            bool operationAccepted = false;
            while (!operationAccepted)
            {
                string? userOperation = Console.ReadLine();

                if (Enum.TryParse<Operation>(userOperation, true, out Operation result))
                {
                    operation = result;
                    operationAccepted = true;
                    Console.Clear();
                    return result;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"{userOperation} not recognized");
                }
               
            }
            return Operation.Addition;
        }

        public int GetUserGuess()
        {
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
                    Console.WriteLine($"{userInput} is not an acceptable response");
                }
            }
            Console.Clear();
            return result;
        }
    }
}
