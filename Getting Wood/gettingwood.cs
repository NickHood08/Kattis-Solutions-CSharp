using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        
        if(input.Contains("tree"))
        {
            Console.WriteLine(input.IndexOf("tree"));
        }
        else
        {
            Console.WriteLine("no trees here");
        }
    }
}
