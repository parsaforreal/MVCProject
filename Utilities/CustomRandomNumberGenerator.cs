using System;

namespace MVCPRoject.Utilities.Models
{
    public static class CustomRandomNumberGenerator
    {
        private static Random random = new Random();

        public static int GenerateRandomNumber()
        {
            return random.Next(0, 2); // Generates a random number between 0 (inclusive) and 2 (exclusive), i.e., 0 or 1
        }
    }
}
