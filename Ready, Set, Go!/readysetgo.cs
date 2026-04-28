using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int[] nums = Array.ConvertAll(input.Split(" "), int.Parse);
        int output = 0;
        
        output = Math.Abs(nums[0] - nums[1]);
        
        Console.WriteLine(output);
    }
}
