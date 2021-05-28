using System;
using System.Text;

namespace LoopsSix
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = 4;
            int i, j, k;
            for (i = 1; i <= val; i++)
            {
                for (j = 1; j <= val - i; j++)
                {
                    // Console.Write("");  
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write(i);
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
