using System;

namespace R_N_G
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialization of inputs
            long multiplier = 7;
            long increment = 0;
            long modulus = 32;
            long seed = 1;
            // creation of object
            var lcg = new LCG(multiplier, increment, modulus, seed);
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(lcg.Next(0, 32));
            }
            Console.ReadLine();
           


        }
    }
}
