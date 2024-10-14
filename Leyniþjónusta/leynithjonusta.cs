using System;

public class Program
{
    public static void Main(string[] args)
    {
        string info = Console.ReadLine();
        string finalEmail = info.Replace(" ", string.Empty);
        Console.WriteLine(finalEmail);
    }
}
