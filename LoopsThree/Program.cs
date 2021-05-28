using System;
using System.Text;

namespace LoopsThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int nLines = 4;

            while (i <= nLines)
            {
                StringBuilder sb = new StringBuilder();
                if (i == 1)
                {
                    sb.Append('*', 4);
                }
                if (i == 2)
                {
                    sb.Append('*', 3);
                }
                if (i == 3)
                {
                    sb.Append('*', 2);
                }
                if (i == 4)
                {
                    sb.Append('*', 1);
                }
                Console.WriteLine(sb);
                i++;
            }
            Console.Read();
        }
    }
}

