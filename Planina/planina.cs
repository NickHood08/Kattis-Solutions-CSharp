using System;

public class Program
{
    public static void Main(string[] args)
    {
        string info = Console.ReadLine();
        int iteration = Int32.Parse(info);
        int e = (int) Math.Pow(2, iteration) + 1;
        Console.WriteLine(e*e);
    }
}
