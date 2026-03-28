namespace Week8;

public static class BoxingTester
{
    public static void Test()
    {
        int a = 10;
        object b = a;
        int c = (int)b;

        // a is stored as an int
        // b stores a boxed copy of a
        // c gets the value after unboxing
        // get all values and print them

        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        Console.WriteLine("c = " + c);
    }
}