using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_practice_19._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                        for (int i  = 1; i <=4;i++)
                        {
                            for (int j  = 1; j <= i; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();    
                        }*/

            for(int i = 1; i <=5; i++)
            {
                for (int j = 1; j <= 5-i; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

            }





        }    
    }
}
