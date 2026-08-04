using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        
        int num = int.Parse(input);
        int total = num * num * num;
        
        Console.WriteLine(total);
    }
}
