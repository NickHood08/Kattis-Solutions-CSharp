using System;

public class Program
{
    public static void Main(string[] args)
    {
        double kilos = 0.09144;
        double roadLength = Double.Parse(Console.ReadLine());
        Console.WriteLine(roadLength * kilos);
    }
}
