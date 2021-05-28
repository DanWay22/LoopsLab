using System;
using System.Text;

namespace LoopsFour
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j = 1;

            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= 4; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine(j);
            }
            Console.ReadLine();
        }
    }
}
