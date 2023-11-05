using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_probmes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // loops pattern problems practice day 1  //

            int n = 5;
            for (int i = 1; i <=n; i++)
            {
                for (int j = 1; j <=n - i ; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <=2 * i ; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //

            int size = 5;
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    if (i == 1 || i == size || j == 1 || j == size)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }


            //
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //\
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    if (k == 1 || k == 2 * i - 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    if (k == 1 || k == 2 * i - 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }


            for (int i = 5; i >=1; i--)
            {
                for(int j = 1; j <=i; j++)
                {
                    Console.Write("*");
                }
                
                Console.WriteLine();
            }

           
           for (int i = 1; i<=5; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //1

            for (int i  = 1; i <=5; i++)
            {
                for(int j = 1; j<=4; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

            //2

            for(int i = 1;i <=5;i++)
            {
                for(int j = 1; j<=4; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

         //1
            for (int i = 5;i <= 9; i++)
            {
                for( int j = 5; j <= 9; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
                
            //2

            for (int i = 5; i <= 9; i++)
            {
                for( int j =5; j <= 9; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            //3
            for (int i = 1;i<=5 ; i++)
            {
                for(int j = 1;j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            //4
            for (int i = 5; i >= 1; i--)
            {
                for (int j = i; j <= 5; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            //5
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j <=5; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

            //6
            for (int i = 5; i >= 1; i--)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            //7
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j<=i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            //8
            for (int i = 1; i <= 5; i++)
            {
              for (int j = i; j >=1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
          

            Console.ReadLine();

        }
    }
}
