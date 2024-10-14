using System;

public class Program
{
    public static void Main(string[] args)
    {
        string info = Console.ReadLine();
        
        int v = Int32.Parse(info.Split(" ")[0]);
        int a = Int32.Parse(info.Split(" ")[1]);
        int t = Int32.Parse(info.Split(" ")[2]);
        
        double part1 = v * t;
        double part2 = (a * (t * t)) *0.5;
        double d = part1 + part2;
        Console.WriteLine(d);
    }
}
