using System;

public class Program
{
    public static void Main(string[] args)
    {
        int num = Int32.Parse(Console.ReadLine());
        int final = (((num + 5) * 3) - 10);
        Console.WriteLine(final);
    }
}
