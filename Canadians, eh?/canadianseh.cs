using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        
        if(input.Substring(input.Length - 3) == "eh?")
        {
            Console.WriteLine("Canadian!");
        }
        else
        {
            Console.WriteLine("Imposter!");
        }
    }
}
