using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string title = input.Split(" ")[0];
        double cap = Double.Parse(input.Split(" ")[1]);
        
        if(title.Length < cap)
        {
            Console.WriteLine(title.Length);
        }
        else
        {
            Console.WriteLine(cap);
        }
    }
}
