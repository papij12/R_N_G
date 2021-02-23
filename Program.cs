using System;

namespace R_N_G
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialization of inputs
            long multiplier = 1664525;
            long increment = 1013904223;
            long modulus = (long) Math.Pow(2,32);
            long initialseed = 1;
            // creation of object
            var lcg = new LCG(multiplier, increment, modulus, initialseed);
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(lcg.Next(initialseed, modulus));
            }
            Console.ReadLine();
           


        }
    }
}
