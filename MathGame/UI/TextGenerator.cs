using System;
using System.Collections.Generic;
using System.Text;
using MathGame.Logic;

namespace MathGame.UI
{
    internal class TextGenerator
    {
        public void StartingPrompt()
        {
            Console.WriteLine("Please select an equation type: addition, subtraction, multiplication or division");
        }

        public void PrintQuestion(int [] integers, Operation operation)
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

            Console.WriteLine($"What is {a} {equationType} {b}?");
        }

        public void CorrectGuess(int a)
        {
            Console.Write($"Correct, the answer is {a}");
        }

        public void IncorrectGuess(int a)
        {
            Console.Write($"Sorry, the answer is not {a}");
        }
    }
}
