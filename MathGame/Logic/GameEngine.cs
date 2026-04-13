using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using MathGame.UI;

namespace MathGame.Logic
{
    internal class GameEngine
    {
        TextGenerator textGenerator = new();

        public void Run()
        {
            textGenerator.StartingPrompt();
            textGenerator.PrintQuestion(1, 2, Operation.Division);
        }
    }

    public enum Operation {Addition, Subtraction, Multiplication, Division}
}
