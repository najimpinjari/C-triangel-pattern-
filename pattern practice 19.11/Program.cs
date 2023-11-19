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

            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(j.ToString());
                Console.WriteLine();
            }
            for (int i = n; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(j.ToString());
                Console.WriteLine();
            }
            Console.WriteLine();



            Console.ReadLine();
        }   
       
    }
}
