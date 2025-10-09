using System;

namespace ByNumb.Services
{
    public class CustomRandom
    {
        private static Random random = new Random();
        public static int Next(int minValue, int maxValue)
        {
            return random.Next(minValue, maxValue);
        }
    }
}
