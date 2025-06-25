/*Write a C# program to print the number of years, days, hours, minutes, seconds - based on given number of seconds.
 
 Eg:

seconds = 288970

The given number of seconds is equivalent to "3 days, 8 hours, 16 minutes, 10 seconds"

Output: 3 days, 8 hours, 16 minutes, 10 seconds

Note: Don't use any control statements such as 'if' or loops.

Don't use any predefined API (classes or structs).*/

using System;
class Program
{ 
static void Main()
    {

        //60sec = 1min
        //1h = 60 min = 3600 seconds 
        //1 day = 24h = 1440 min = 86400 sec
        Console.WriteLine("Please insert the number of seconds: ");
        int seconds = Convert.ToInt32(Console.ReadLine());
        int days = seconds / 86400;
        int hours = (seconds% 86400) / 3600;
        int minutes = (seconds % 3600)/60;
        int remainingSeconds = seconds % 60;
        Console.WriteLine("It is: " + days+
           " Days "+ hours +" hours "+ minutes + " minutes "+remainingSeconds+" sec." );
        Console.ReadKey();

    }
}

