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
            Console.WriteLine("Welcome to the math game! Please select which type of problem you would like to start with");
        }

        public void PrintQuestion(int a, int b, Operation operation)
        {
            string equationType = operation switch
            {
                Operation.Addition => "plus",
                Operation.Subtraction => "minus",
                Operation.Multiplication => "multiplied by",
                Operation.Division => "divided by",
            };

            Console.WriteLine($"What is {a} {equationType} {b}?");
        }
    }
}
