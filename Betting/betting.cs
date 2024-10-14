using System;

public class Program
{
    public static void Main(string[] args)
    {
        double a = Double.Parse(Console.ReadLine());
        Console.WriteLine(100 / a);
        Console.WriteLine(100 / (100 - a));
    }
}
