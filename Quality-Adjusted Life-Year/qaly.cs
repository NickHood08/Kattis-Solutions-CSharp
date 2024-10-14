using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n = Int32.Parse(Console.ReadLine());
        double total = 0.0;
        for(int i = 0; i < n; i++)
        {
            string info = Console.ReadLine();
            double q = Double.Parse(info.Split(" ")[0]);
            double y = Double.Parse(info.Split(" ")[1]);
            total += (q * y);
        }
        Console.WriteLine(total);
    }
}
