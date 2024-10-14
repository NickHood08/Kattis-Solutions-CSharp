using System;

public class Program
{
    public static void Main(string[] args)
    {
        double seedCost = Double.Parse(Console.ReadLine());
        int l = Int32.Parse(Console.ReadLine());
        double cost = 0.0;
        for(int i = 0; i < l; i++)
        {
            string nums = Console.ReadLine();
            double width = Double.Parse(nums.Split(" ")[0]);
            double length = Double.Parse(nums.Split(" ")[1]);
            cost += ((width * length) * seedCost);
        }
        Console.WriteLine(cost);
    }
}
