/*Write a C# program to get nearest thousand of given integer number. Here, let name the input value as "number".
 Instructions
If the number's last three digits are greater than or equal to 500; it should "round up" the number.

If the number's last three digits are less than 500; it should "round down" the number.

If the number is less than 500; it should round up to 1000.

Eg:

Input: 499  Output: 1000

Input: 500  Output: 1000

Input: 999  Output: 1000

Input: 1000 Output: 1000

Input: 1499 Output: 1000

Input: 1500 Output: 2000

Note: Don't use any predefined math functions.*/


class Program
{

    static void Main ()
    {
        Console.WriteLine("Nearest Thousand Calculation:");
        Console.WriteLine("Please submit integer value of the number to calculate");
        int number = Convert.ToInt32(Console.ReadLine());
        int wholeThousand = number / 1000;
        Console.WriteLine("Number of full thousand: "+ wholeThousand*1000);
        int lastThree = number % 1000;
        Console.WriteLine("Last three digits are: "+ lastThree);

        int nearestThousand;

        if (lastThree < 500 && wholeThousand < 1)
        {
            nearestThousand = 1000;
        }
        else if (lastThree < 500 && wholeThousand >= 1)
        {
            nearestThousand = wholeThousand*1000;
        }
        else if(lastThree >=500 && wholeThousand >= 1)
        {
          nearestThousand = wholeThousand * 1000+ 1000;
        }
        else 
        { 
            Console.WriteLine("Something went wrong.Error.");
            nearestThousand = 0;
        }

        
        Console.WriteLine("The nearest thousand is " + nearestThousand);
        Console.ReadKey();


    }
}





