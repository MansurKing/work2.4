using System;

namespace work2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            for (int i = 0; i <= 100; i++)
            {
                i = rand.Next(0, 16);

                if (i % 5 == 0 || i % 3 == 0)
                {
                    Console.WriteLine(i);
                    Console.ReadKey();
                }

            }

        }
    }
}
