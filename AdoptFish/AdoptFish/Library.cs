using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AdoptFish
{
    internal class Library
    {
        static Random randomNumberGenerator = new Random();
        public static int GetRandomNumber(int max)
        {
            return randomNumberGenerator.Next(max);
        }

        public static int GetRandomNumber(int min, int max)
        {
            return randomNumberGenerator.Next(min, max);
        }
    }
}
