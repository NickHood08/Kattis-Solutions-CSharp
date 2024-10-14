using System;

public class Program
{
    public static void Main(string[] args)
    {
        string info = Console.ReadLine();
        int num1 = Int32.Parse(info.Split(" ")[0]);
        int num2 = Int32.Parse(info.Split(" ")[1]);
        Console.WriteLine(num1 + num2);
    }
}
