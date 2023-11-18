using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baterfly_pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = 4;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                for (int j = 1; j <= 2 * (n - i); j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= n * 2; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                for (int j = 1; j <= 2 * (n - i); j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            int m = 4;

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                for (int j = 1; j <= 2 * (m - i); j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();




            }
        }
    }
}
