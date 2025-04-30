using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] splitInput = input.Split(".");
        int fileNameLocation = splitInput.Length - 1;
        
        Console.WriteLine("." + splitInput[fileNameLocation]);
    }
}
