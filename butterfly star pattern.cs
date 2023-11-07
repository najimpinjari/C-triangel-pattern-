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

            // loops pattern problems practice day 2  //


                  int m = 7; // You can change this value to adjust the size of the pattern

                // Upper half of the butterfly star pattern
                for (int i = 1; i <= m; i++)
                {
                    Console.Write(new string('*', i));
                    Console.Write(new string(' ', 2 * (m - i)));
                    Console.Write(new string('*', i));
                    Console.WriteLine();
                }

                // Lower half of the butterfly star pattern
                for (int i = m; i >= 1; i--)
                {
                    Console.Write(new string('*', i));
                    Console.Write(new string(' ', 2 * (m - i)));
                    Console.Write(new string('*', i));
                    Console.WriteLine();
                }



            for (int i = 1; i <= m; i++)
            {
                Console.Write(new string('*', i));
                Console.Write(new string(' ', 2 * (m - i)));
              //  Console.Write(new string('*', i));
                Console.WriteLine();


                //1

                //Problem 1: Print a Square Star Pattern


                /** *****
                    *****
                    *****
                    *****
                   } *****
*/

                int n = 5;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();

                }

                //Problem 2: Print a Right Angle Triangle


                int c = 5;
                for (int i = 1; i <= c; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }

                //3

                int s = 5;

                for (int i = 1; i <= 5; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("4\n\n");

                //4
                for (int i = 0; i < 11; i++)
                {
                    for (int k = 0; k < 11; k++)
                    {
                        if (i < (11 / 2))
                        {
                            if (k <= i)
                            {
                                Console.Write("* ");
                            }
                            else if (k >= (11 - i) - 1)
                            {
                                Console.Write("* ");
                            }
                            else
                            {
                                Console.Write("  ");
                            }

                        }

                        if (i == 11 / 2)
                        {
                            Console.Write("* ");
                        }
                        if (i > 11 / 2)
                        {
                            if (k < (11 - i))
                            {
                                Console.Write("* ");

                            }
                            else if (k < (11 = i))
                            {
                                Console.Write("* ");
                            }
                            else
                            {
                                Console.Write("  ");

                            }
                            Console.WriteLine();

                        }


                    }
                }





            }

            Console.ReadLine();

        }
    }
}
