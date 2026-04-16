using MathGame.Logic;

namespace MathGame.UI
{
    internal class DataHandler
    {
        public void DisplayData(List<GameData> data)
        {
            int counter = 1;

            // Loop for priting game data
            foreach (GameData game in data)
            {
                Console.WriteLine($"Game number {counter}: Score {game.Correct} / {game.Total}");
                counter++;
            }

            Console.WriteLine();
        }
    }
}
