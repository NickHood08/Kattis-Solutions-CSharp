using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string updatedInput = new string(charArray);
        Console.WriteLine(updatedInput);
    }
}
