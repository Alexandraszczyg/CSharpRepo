/*Write a program to find out "category of height" based on the given height of a person (in inches), using "if".
 
 Height categories:

Height is less than 150 cm = "Dwarf"

Height is between 150 cm and 165 cm = "Average height"

Height is between 165 cm and 195 cm = "Tall"

Height is above 195 cm = "Abnormal height"


Note: 1 inch = 2.54 centimeter

You need to convert the input value (inches) into centimeters.

Eg:

Input: 75

Output: Tall*/

using System;
namespace HeightCategory.NETFramework
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Height category sorting hat: ");
            Console.WriteLine("Please kindly input the height in inches: ");
            double heightInInches = Convert.ToDouble(Console.ReadLine());
            double heightInCm = heightInInches * 2.54;
            Console.WriteLine("Height in cm is: "+heightInCm);


            if (heightInCm < 150)
            { Console.WriteLine("The person is a dwarf"); }
            else if (heightInCm < 165 && heightInCm > 150)
            { Console.WriteLine("The person is of Average Height"); }
            else if (heightInCm < 195 && heightInCm > 165)
            { Console.WriteLine("The person is tall."); }
            else if (heightInCm > 195)
            { Console.WriteLine("The person is abnormal height."); }
            else { Console.WriteLine("Something went wrong, please restart the app."); }

            Console.ReadKey();
        }
    }
}
