using System;

public class Program
{
    public static void Main(string[] args)
    {
        string word = Console.ReadLine();
        int firstA = word.IndexOf('a');
        Console.WriteLine(word.Substring(firstA));
    }
}
