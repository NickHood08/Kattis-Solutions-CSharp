using System;

public class Program
{
    public static void Main(string[] args)
    {
        string info = Console.ReadLine();
        int num1 = Int32.Parse(info.Split(" ")[0]);
        int total = Int32.Parse(info.Split(" ")[1]);
        int num2 = (total * 2) - num1;
        Console.WriteLine(num2);
    }
}
