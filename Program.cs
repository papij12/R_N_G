using System;

namespace R_N_G
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(11, 20));
            }

            Console.ReadLine();
        }
    }
}
