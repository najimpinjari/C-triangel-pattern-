using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace using_Array_find_highest_number
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int start = 0; // initialization 
            while (start <= 0) //condition 
            {
                Console.WriteLine(start); // body
                start ++; // updation 
            }

            //example  

          
            
            int i = 1;

                while (i <= 5)
                {
                    Console.WriteLine("The value of i is: " + i);
                    i++;
                }

            //do while loop

            int n = 1;

            do 
            {
                Console.WriteLine("The value of i is: " + n);
                n++;
            } while (i <= 5);


            // for loop 

            for (int c = 1; c <= 5; c++)
                //initialization //condition //updation 
            {
                Console.WriteLine(c);// body
            }

            //nested loops 

            for(int i = 1 ; i <= 5; i++) //outer loop
            {
                for(int c = 1 ; c <= 5; c++) //inner loop 
                {
                    Console.Writei(i); // for print 
                }

                Console.writeline(); //this line for next line 
            }








            Console.ReadLine();
        }
    }
}
