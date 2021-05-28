using System;
using System.Text;

namespace LoopsOne
{
    class Program
    {
        static void Main(string[] args)
        {
         int i = 0;
         int nLines = 2;

         StringBuilder sb = new StringBuilder();
         sb.Append('*', 5);

         while (i <= nLines)
         {
            Console.WriteLine(sb);
            i++;
          }
         Console.Read();
        }
    }
 }

