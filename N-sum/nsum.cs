using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n = Int32.Parse(Console.ReadLine());
        string nums = Console.ReadLine();
        int total = 0;
        for(int i = 0; i < n; i++)
        {
            total += Int32.Parse(nums.Split(" ")[i]);
        }
        Console.WriteLine(total);
    }
}
