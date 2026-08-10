using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] names = input.Split(", ");
        string lastName = names[0];
        string firstName = names[1];
        
        string formatName = char.ToUpper(firstName[0]) + ". " + char.ToUpper(lastName[0]) + lastName[1..];
        
        Console.WriteLine(formatName);
    }
}
