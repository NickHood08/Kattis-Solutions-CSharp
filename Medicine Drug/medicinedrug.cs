using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        
        double[] nums = Array.ConvertAll(input.Split(" "), double.Parse);
        
        int totalBoxes = (int) Math.Ceiling((nums[0] * nums[1]) / nums[2]);
        
        Console.WriteLine(totalBoxes);
    }
}
