using System;

public class Program
{
    public static void Main(string[] args)
    {
        string info = Console.ReadLine();
        int numCarrots = Int32.Parse(info.Split(" ")[1]);
        Console.WriteLine(numCarrots);
    }
}
