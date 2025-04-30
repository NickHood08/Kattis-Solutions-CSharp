using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int num1 = Int32.Parse(input.Split(" ")[0]);
        int num2 = Int32.Parse(input.Split(" ")[2]);
        
        if(num1 > num2)
        {
            Console.WriteLine(">");
        }
        else if(num1 < num2)
        {
            Console.WriteLine("<");
        }
        else
        {
            Console.WriteLine("Goggi svangur!");
        }
    }
}
