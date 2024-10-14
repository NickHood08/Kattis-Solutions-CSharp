using System;

public class Program
{
    public static void Main(string[] args)
    {
        string nums = Console.ReadLine();
        int num1 = Int32.Parse(nums.Split(" ")[0]);
        int num2 = Int32.Parse(nums.Split(" ")[1]);
        Console.WriteLine(num1 + num2);
    }
}
