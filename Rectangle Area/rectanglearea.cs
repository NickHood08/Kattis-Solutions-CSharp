using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        double[] coords = Array.ConvertAll(input.Split(" "), double.Parse);
        double length = 0.0;
        double width = 0.0;
        double final = 0.0;
        
        length = coords[0] - coords[2];
        width = coords[1] - coords[3];
        final = Math.Abs(length) * Math.Abs(width);
        
        Console.WriteLine(Math.Round(final, 3));
    }
}
