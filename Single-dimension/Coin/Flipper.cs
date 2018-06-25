namespace Learning.Arrays.Coin
{
    using System;

    public class Flipper
    {
        private const int Heads = 0;
        private readonly Random _random = new Random();

        public void DisplayFor(int flips, int experiments)
        {
            int i, j, times;
            // Create the array to store the results
            var frequency = new int[flips + 1];

            // Run all the experiments
            for (i = 0; i < experiments; i++, frequency[times]++)
            {
                // Flip the coin
                for (times = 0, j = 0; j < flips; j++)
                {
                    // When coin is heads I increase the times value
                    // which is stored after this loop is done in the frequency table
                    if (IsHeads())
                    {
                        times++;
                    }
                }
            }

            // Display the results
            for (i = 0; i <= flips; i++)
            {
                Console.Write(i);
                for (j = 0; j < frequency[i]; j += 10)
                {
                    Console.Write("*");
                }
                Console.WriteLine($" -- ({frequency[i]})");
            }
        }

        private bool IsHeads()
        {
            var coinFlip = _random.Next(0, 2);
            return coinFlip == Heads;
        }
    }
}