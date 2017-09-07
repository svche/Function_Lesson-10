using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_10
{
    class Program
    {
        static void Main(string[] args)
        {

//          Задача 10.7
//Написать функцию вычисления суммы целых чисел от 1 до N.

            /*
            Console.WriteLine("Addition. Enter two numbers from one\n");

            Console.Write("Enter number first: ");
            int first = int.Parse(Console.ReadLine());

            Console.Write("Enter number second: ");
            int second = int.Parse(Console.ReadLine());

            Addition(first, second);
            */


//          Задача 10.8
//Решить задачу 10.7 при помощи рекурсии

            /*
            int first = 0, second = 0;
            Console.WriteLine("Addition");

            int sum = AdditionRecurs(first, second);
            Console.WriteLine("\tSum is: " + sum);
            */


            //10.9
// Создать две функции,в которые передается массив чисел.
//  Функции должны возвратить минимальный и максимальный элемент 
//  массива соответственно.
//массив передается следующим образом: void printArray(int[] array)



            int[] array = new int[10];
            for (int i = 0; i < 10; i++) array[i] = i;

            PrintArrayMin(array);
            PrintArrayMax(array);


            Console.ReadLine();
        }

        static void PrintArrayMax(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
            }
                Console.WriteLine("Maximum number is: " + max);
        }

        static void PrintArrayMin(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min) min = array[i];
            }
                Console.WriteLine("Minimum number is: " + min);
        }

        static int AdditionRecurs(int num1, int num2)                               //task 10.8
        {
            Console.WriteLine("\tEnter two numbers from one\n");

            Console.Write("Number first: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Number second: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 < 1 || num2 < 1) return AdditionRecurs(num1, num2);
            else
            {
                int res = num1 + num2;
                return res;
            }
        }

        static void Addition(int num1, int num2)                               //task 10.7
        {
            if (num1 < 1 || num2 < 1)
            {
               Console.WriteLine("Mistake. Try again.");
            }
             else
            {
              Console.WriteLine("The sum is: {0}", add(num1, num2));
            }
        }
        
        static int add(int num1, int num2)
        {
                int result = num1 + num2;
                return result;
        }
    }
}
