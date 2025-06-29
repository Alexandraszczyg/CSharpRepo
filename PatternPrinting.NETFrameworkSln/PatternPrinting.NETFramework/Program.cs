/*Write a C# program to print the following output by using 'for' loop, 'break' and 'continue' statements
1 2 3 4 7 8 9 10
1 2 3 4 7 8 9 10
1 2 3 4 7 8 9 10
10 9 8 7 6 5 4 3 2 1
10 9 8 7 6 5 4 3 2 1
10 9 8 7 6 5 4 3
10 9 8 7 6 5 4 3 2 1
1 2 3 4 5 6 7 9 10

Each number should be printed by using the loop variable.

Don't print full line at-a-time as string.

For example, don't write statements as:

System.Console.WriteLine("1 2 3 4 7 8 9 10");



Use for loop, break and continue statements to bring the output.
 */
using System;


namespace PatternPrinting.NETFramework
{
    internal class Program
    {
        static void Main()
        {

            // repeats the lines 3 times

            for (int i = 1; i <= 3; i++)

            {

                //prints 1 to 10 with spaces in between

                for (int j = 1; j <= 10; j++)

                {   //skips 5 and 6 and continues to the next iteration

                    if (j == 5 | j == 6)

                    { continue; }



                    System.Console.Write(j);

                    System.Console.Write(" ");

                }

                // Jumps to the next line after displaying inner loop

                System.Console.WriteLine();

            }

            // repeats the loop four times

            for (int k = 1; k <= 4; k++)

            {



                // prints the numbers 10 to 1

                for (int l = 10; l >= 1; l--)

                {

                    // for 2 and 1 break

                    if (k == 3 && l <= 2)

                    { break; }

                    System.Console.Write(l);

                    System.Console.Write(" ");

                }



                //Jumps to the next line after displaying inner loop

                System.Console.WriteLine();

            }

            //prints values  from 1 to 10

            for (int m = 1; m <= 10; m++)

            {

                // skips 8 and continues to the next iteration

                if (m == 8)

                { continue; }



                System.Console.Write(m);

                System.Console.Write(" ");



            }

            System.Console.ReadKey();
        }
    }
}
