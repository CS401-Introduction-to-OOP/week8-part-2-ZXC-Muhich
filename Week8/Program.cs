namespace Week8;
using System;


class Program
{
    public static void Main()
    {
        Point p1 = new Point { X = 1, Y = 2 };
        Point p2 = p1;

        p2.X = 10;
        p1.Print();
        p2.Print();
        Console.WriteLine();

        // Point is a struct, so p2 is a copy of p1
        // PointRef is a class, so r1 and r2 reference the same object
        
        PointRef r1 = new PointRef { X = 1, Y = 2 };
        PointRef r2 = r1;

        r2.X = 10;
        r1.Print();
        r2.Print();
        Console.WriteLine();
        BoxingTester.Test();
    }
}