using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] words = input.Split(" ");
        string finalWord = words[words.Length - 1];
        
        Console.WriteLine(finalWord + "slop");
    }
}
