using System.Drawing;

namespace Practice_7_10_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<......NUMBER PROGRAMS......>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>// 

            //..........................................SWAPPING THE TWO NUMBER WITHOUT USING 3RD VARIABLE.........................................//


            //Console.WriteLine("Enter the 1st number : ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the 2nd number : ");
            //int number2 = int.Parse(Console.ReadLine());
            //Console.WriteLine($" Before swapping 1st number = {number1} and 2nd number = {number2}");

            //// swapping 
            //number1 = number1 + number2;
            //number2= number1- number2;
            //number1=number1- number2;
            //Console.WriteLine($" After swapping 1st number = {number1} and 2nd number = {number2}");


            //..................................................PRIME NUMBER OR NOT..............................................................//

            //Console.WriteLine("Enter the  number : ");
            //int number = int.Parse(Console.ReadLine());
            //int count = 0;

            //if (number == 0)
            //{
            //    Console.WriteLine("Not considerable for checking the condition!!!");
            //}
            //else if (number == 1)
            //{
            //    Console.WriteLine(" 1 is not a prime number");

            //}
            //else if (number == 2)
            //{
            //    Console.WriteLine(" 2 is the smallest prime number");

            //}
            //else
            //{
            //    for (int i = 3; i <= number; i++)
            //    {
            //        if(number % i==0)
            //        {
            //            count++;
            //        }
            //    }
            //}
            //if (count == 1)
            //{
            //    Console.WriteLine("Number is a prime number");
            //}
            //else
            //{
            //    Console.WriteLine("Number is not a prime number");
            //}


            //..................................................PRINTING THE FACTORIAL.......................................................//

            Console.WriteLine("Enter the number : ");
            int num = int.Parse(Console.ReadLine());
            int result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;

            }
            Console.WriteLine($"Facctorial of the given number is {result}");

        }

    }
}




























