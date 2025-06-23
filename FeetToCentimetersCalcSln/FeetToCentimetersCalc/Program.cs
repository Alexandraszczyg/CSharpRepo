using System;

//Write a C# program convert a person's height (in feet and inches) to centimeters.
/*feet = 5 inches = 7 output: 170.18 cm Formula:
1 inch = 2.54 cm
1 feet = 12 inches*/


class Program
{ 
static void Main()
    {
        Console.WriteLine("Height converter:");
        Console.WriteLine("Please input the number of feet:");
        double feetinput= Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please input the number of inches:");
        double inchesinput = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Now converting to centimeters:");
        double centimeters = 0;
        //inches = 2.54 * centimeters;
        //feet = 12 * inches;

     double inchesconv = feetinput*12;
     centimeters = (inchesconv + inchesinput) * 2.54;

        Console.WriteLine("The number of centimeters is "+centimeters+"cm.");
        Console.ReadKey();
    }
}
