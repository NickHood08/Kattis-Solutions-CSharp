using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string left = input.Split("()")[0];
        string right = input.Split("()")[1];
      
        if(left.Length == right.Length)
        {
            Console.WriteLine("correct");
        }
        else
        {
            Console.WriteLine("fix");
        }
    }
}
