using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace M5_LA1_Recursive_Print_Letters
{
    //Learning Activity 1: Recursive Print Letters
     //Write a recursive function(s) that prints n characters from A.

    class Program
    {
        /*static void Print1toN(int n)            //iterative loop to print 100 numbers
        {
            for (int i = 1; i <= n; i++) 
            {
                Console.Write(i + " ");
            }
        }*/

        static void RecPrint1toN(int n)                 //recursive function 
        {
            if (n == 0) return;                   //going to stop my program
            
            //Console.Write(n + " ");           //this will wrtie the statement before the function call - will dive you decending order  10, 9, 8, 7, ...
            RecPrint1toN(n - 1);              // if n==10, n not ===0, i'm going to call the function again RecPrint(10-1)= 9, n now equal 9, finish all function calls before console.writeline printed
            Console.Write(n + " ");             //finish all the function calls- will give you a ascending oreder 1, 2, 3, ect 
        }


        static void Main(string[] args)
        {

            RecPrint1toN(100);
            Console.Read();
        }
    }
}
