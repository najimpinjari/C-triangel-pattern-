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

            // loops pattern problems //
            //1

            for ( int i = 1;i <= 5;i++)
            {
                for ( int j = 1;j <= 4;j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();

            }

            //2

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    Console.Write(i);
                    Console.Write(j);
                    Console.Write(" ");

                }
                Console.WriteLine();
            }
            //3

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();

            }

            //4

            for(int i = 1;i <=5 ; i++)
            {
                for(int j = 1;j<=4; j++ )
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }   

            //5

            for(int i = 1; i<=4; i++)
            {
                for( int j = 1;j<=5 ; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
               
            //6

            for ( int i = 1;i<=4 ; i++)
            {
                for(int j =1;j<=6 ; j++)
                {
                    Console.Write(j);
                }     
                Console.WriteLine();    
            }

            //7

            for(int i = 5;i>=1; i--)
            {
                for (int j = 1;j<=4 ;j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();

            }

            //8

            for (int i =1;i<=5 ; i++)
            {
                for(int j =4;j>=1 ; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            //9

            for(int i = 4;i>=0;i--)
            {
                for(int j = 0 ;j>=5 ; j--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

            //10

            for (int i = 1;i<=4;i++)
            {
                for(int j =1 ;j<=5 ; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

           //11
           for (int i = 1;i<=5;i++)
           {
                for(int j =1 ;j<=i ; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();    
           }

           //12

           for (int i = 5; i >= 1; i--)
            {
                for (int j = i ;j<=5 ; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
           }
                
           //13
           for (int i = 1;i<=5; i++)
            {
                for (int j =5 ;j>=i ; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
           }

           //14

           for (int i = 5; i >= 1; i--)
            {
                for (int j=i ;j <=5;j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }





            Console.ReadLine();

        }
    }
}
