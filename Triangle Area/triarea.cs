using System;

public class Program
{
    public static void Main(string[] args)
    {
        string info = Console.ReadLine();
        double h = Double.Parse(info.Split(" ")[0]);
        double b = Double.Parse(info.Split(" ")[1]);
        double area = (b * h) / 2;
        Console.WriteLine(area);
    }
}
