using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_types_22._11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //*
            for(int i = 1; i <=5; i++)
            {
                for(int j = 1; j <=i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            //*
            int v = 4;
            for(int i = 1; i <=v; i++)
            {
                for (int j = 1; j <=v-i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //*

            for(int i = 4; i >=1; i--)
            {
                for (int j = i; j >=1; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //*


            for(int i = 1; i <=4; i++)
            {
                for(int j = 1; j <=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //*
            int n = 4, m = 5;


            for(int i = 1; i <=n;  i++)
            {
                for(int j = 1; j <=m; j++)
                {
                    if (i == 1 || j == 1 || i == n || j == m)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            // * 

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
