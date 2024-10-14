using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNums = Console.ReadLine();
        int num1 = Int32.Parse(strNums.Split(" ")[0]);
        int num2 = Int32.Parse(strNums.Split(" ")[1]);
        Console.WriteLine((num1 * (num2 - 1)) + 1);
    }
}
