using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_10_0509_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string str = Console.ReadLine();
            PrintSymb(str);
            */

            /*
            int f = 6;
            int res = sum(ref f, 2);
            Console.WriteLine(f);
            */

            /*
            int a = 25;
            int b = 52;
            Console.WriteLine("A is {0} \nB is {1}", a, b);

            swap(ref a, ref b);

            Console.WriteLine("\nAfter SWAP:");
            Console.WriteLine("A is {0} \nB is {1}", a, b);
            */

            /*
            Console.Write("Enter the symbol for repeat: ");
            string symb = Console.ReadLine();

            Console.Write("Enter count for repeating: ");
            int count = int.Parse(Console.ReadLine());

            PrintSymbCount(symb, count);
            */

            /* 
            Console.Write("Enter the number to calculate the factorial: ");
            int numIn = int.Parse(Console.ReadLine());

            Console.WriteLine("\nFactorial of {0} is:  {1:###,###}.", numIn, Factorial(numIn)); 
            */

            /*
            PrintNum(45);
            */


            Print("W", 50, 80, 'z');


            Console.ReadLine();
        }

        static void Print(string sym, int count, int num_border, char symb_border)
        {
            borderPrint(num_border, symb_border);
            Print(sym, count);
            borderPrint(num_border, symb_border);
        }

        static void Print(string sym, int count, int num_border)
        {
            borderPrint(num_border);
            Print(sym, count);
            borderPrint(num_border);
        }

        static void borderPrint(int num_border, char sym_border)
        {
            for (int i = 0; i < num_border; i++)
            {
                Console.Write(sym_border);
            }
            Console.WriteLine();
        }

        static void borderPrint(int num_border)
        {
            for (int i = 0; i < num_border; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        static void Print(string sym, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(sym + "\t");
            }
            Console.WriteLine();
        }

        static void Print(string sym)                    // overload and go up^
        {
            Console.WriteLine(sym);
        }

        static void PrintNum(int num)                     // type definition
        {
            Console.WriteLine("Integer " + num);        
        }

        static void PrintNum(double num)                // type definition
        {
            Console.WriteLine("Double " + num);
        }

        static long Factorial(int num)       // function calls itself !!!
        {
            if (num == 0) return 1;
            return num * Factorial(num - 1);
        }

        static long Factorial1(int num)
        {
            long resFac = 1;
            if (num == 0) return resFac;

            for (int i = 1; i <= num; i++)
            {
                resFac *= i;
            }
            return resFac;
        }

        static void PrintSymbCount(string symb, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(symb);
            }
        }

        static void PrintSymb(string symb)
        {
            nextPrint();
            Console.WriteLine(symb);
        }
        static void nextPrint()
        {
            Console.Write("The symbol is: ");
        }
        
        static int sum(ref int first, int second)
        {
            first = 45;
            int result = first + second;
            return result;
        }
   
        static void swap(ref int first, ref int second)
        {
            int temp = first;
            first = second;
            second = temp;
        }

    }
}
