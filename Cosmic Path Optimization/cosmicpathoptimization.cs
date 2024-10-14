using System;

public class Program
{
    public static void Main(string[] args)
    {
        int num = Int32.Parse(Console.ReadLine());
        string allNums = Console.ReadLine();
        int[] nums = Array.ConvertAll(allNums.Split(" "), int.Parse);
        int total = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            total += nums[i];
        }
        Console.WriteLine(total / num);
    }
}
