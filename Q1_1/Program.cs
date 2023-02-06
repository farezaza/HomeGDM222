using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine(f(x));
    }

    public static double f(double x)
    {
        if(x * x <= 4) {return 2;}
       return 1 + f(x-((4*Math.Abs(x))/x));
    }
}