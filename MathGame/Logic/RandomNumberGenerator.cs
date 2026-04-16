namespace MathGame.Logic
{
    internal class RandomNumberGenerator
    {
        Random random = new();

        public int[] GetRandomIntegers()
        {
            int a = random.Next(1, 11);
            int b = random.Next(1, 11);
            int[] integers = new int[] { a, b };

            return integers;
        }
    }
}
