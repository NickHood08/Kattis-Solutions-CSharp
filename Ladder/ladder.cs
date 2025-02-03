using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int h = Int32.Parse(input.Split(" ")[0]);
        int angle = Int32.Parse(input.Split(" ")[1]);
        int length = (int) Math.Ceiling(h / Math.Sin((Math.PI / 180) * angle));
        Console.WriteLine(length);
    }
}
