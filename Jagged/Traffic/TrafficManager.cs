namespace Learning.Arrays.Jagged.Traffic
{
    using System;
    using System.Collections.Generic;

    public class TrafficManager
    {
        /// <summary>
        /// Returns traffic records for the current week.
        /// </summary>
        /// <returns>Returns a jagged array of string for each day of the week.</returns>
        public static string[][] GetWeeklyRecords()
        {
            var weeklyTraffic = new string[7][];
            for (var i = 0; i < weeklyTraffic.Length; i++)
            {
                var cars = Data.GetCarsFor(i);
                weeklyTraffic[i] = cars;
            }

            return weeklyTraffic;
        }

        /// <summary>
        /// Prints records contents, which are stored in the jagged array.
        /// </summary>
        /// <param name="records">The jagged array that hodls the traffic records.</param>
        public static void PrintWeeklyRecords(string[][] records)
        {
            for (var i = 0; i < records.Length; i++)
            {
                var inner = records[i];
                Console.WriteLine($"During {(DayOfWeek)i}, {inner.Length} cars passed.");
                for (var j = 0; j < inner.Length; j++)
                {
                    Console.Write("{0}{1, -3}", inner[j], j == inner.Length - 1 ? string.Empty : ", ");
                }

                Console.WriteLine("\n\n");
            }
        }
    }

    internal static class Data
    {
        private static readonly IDictionary<int, string[]> InMemoryData = new Dictionary<int, string[]>
        {
            [0] = new[] { "NUB 8256", "EDD 8015" },
            [1] = new[] { "EVO 5499", "IYO 5978", "OOZ 1434", "OLD 2984" },
            [2] = new[] { "OOZ 1434", "OLD 2984" },
            [3] = new[] { "NOB 2656", "FAX 4438", "WEE 1935", "KKI 4222", "GAP 8485" },
            [4] = new[] { "FAX 4438", "WEE 1935", "KKI 4222", "OOZ 1434", "OLD 2984", "NUB 8256" },
            [5] = new[] { "SOB 1258", "LLL 1463", "GUM 3007", "OWW 0440", "SAT 6676", "BOI 0151" },
            [6] = new[] { "WEE 1935", "KKI 4222", "SOB 1258", "OWW 0440", "SAT 6676", "EDD 8015", "NUB 8256" }
        };

        public static string[] GetCarsFor(int index) => InMemoryData[index];
    }
}