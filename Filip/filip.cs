using System;

public class Program
{
    public static void Main(string[] args)
    {
        string nums = Console.ReadLine();
        string num1 = nums.Split(" ")[0];
        string num2 = nums.Split(" ")[1];
        char[] charArray = num1.ToCharArray();
        Array.Reverse(charArray);
        string reversedNum1 = new string(charArray);
        charArray = num2.ToCharArray();
        Array.Reverse(charArray);
        string reversedNum2 = new string(charArray);
        Console.WriteLine(Math.Max(Int32.Parse(reversedNum1), Int32.Parse(reversedNum2)));
    }
}
