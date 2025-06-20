using System;


public class Calc
{
    public double var1;//radius
    public double var2;//pi
    public double var3;//height
    public double var4;//length
    public double result1;// result of calculate area of cicle
    public double result2;// result of calculate area of square
    public double result3;//result of calculate volume of cilinder


    public double CalculateAreaOfCircle()
    {
       
        Console.WriteLine("Initiating Calculation of Area of Circle");
        
        Console.WriteLine("Please input the radius in cm");
        //Reading the radius value from the keyboard
        double radius = Convert.ToDouble(Console.ReadLine());
        var1=radius;
        //Reading the value of Pi
        double pi = Math.Round(Math.PI, 5);
        var2=pi;
        Console.WriteLine("The pi is " + pi);

        double result = radius * radius * pi;
        result1=result;

        Console.WriteLine("The area of circle is " + result1 + "cm2.");

        return result1;
    }

    public double CalculateAreaOfSquare()
    {
       
        Console.WriteLine("Initiating Calculation of Area of Square");
       
        Console.WriteLine("Please input the length in cm");
        //Reading the length value from the keyboard
        double length = Convert.ToDouble(Console.ReadLine());
        //Reading the value of Pi
        Console.WriteLine("Please input the height in cm");
        double height = Convert.ToDouble(Console.ReadLine());

        var3=height;
        var4=length;

        double result = length*height;

        result2=result;

        Console.WriteLine("The area of square is " + result2 + "cm2.");

        return result2;


    }
  public double CalculateVolumeOfCilinder()
    {
       
        Console.WriteLine("Initiating Calculation of Volume of Cilinder");

        
        Console.WriteLine("Radius is equal to " + var1 + "cm");

        //Density of cilinder 2πr(r + h)= 2πr^2+2πrh
      
        Console.WriteLine("The pi is " + var2);
      
        Console.WriteLine("Height is equal to " + var3+ "cm");

        double result = 2 * result1 + 2 * var2*var3*var1;
        result3=result;
        Console.WriteLine("Result is equal to "+ result3+ "cm3");
        return result3;
    }

}

public class Program
{
    static void Main()
    {
        Calc c = new Calc();
        c.CalculateAreaOfCircle();
        c.CalculateAreaOfSquare();
        c.CalculateVolumeOfCilinder();
        Console.ReadKey();
    }
}


