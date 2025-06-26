/*Write a C# program to find out largest number among three numbers, using "if".
 Eg:
num1 = 60
num2 = 45
num3 = 123
Output: 123*/

using System;

namespace LargestOfThreeNumbers.NETFr
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Which number is the largest calculation:");

            Console.WriteLine("Please input number1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input number2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input number3: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if(num1>num2 &&num1>num3)
            {Console.WriteLine("The largest number is number1 equal to: "+num1);}
            else if(num2>num1 && num2>num3)
            { Console.WriteLine("The largest number is number2 equal to: "+num2);}
            else if(num3>num1 && num3>num2)
            { Console.WriteLine("The largest number is number3 equal to: "+num3);}
            else {Console.WriteLine("No largest number present. Please try again."); }
                
            Console.ReadKey();
        }
    }
}
