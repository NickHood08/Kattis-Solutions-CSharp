using System;

public class Program
{
    public static void Main(string[] args)
    {
        double num = Double.Parse(Console.ReadLine());
        double result = Math.Round((num / (double) 4), 2);
        Console.WriteLine(result);
    }
}
