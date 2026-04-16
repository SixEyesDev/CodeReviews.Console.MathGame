namespace MathGame.Logic
{
    internal class GameData
    {
        public int Correct { get; }
        public int Total { get; }


        public GameData(int correct, int total)
        {
            Correct = correct;
            Total = total;
        }
    }
}
