using System;

public class Program
{
    public static void Main(string[] args)
    {
        int numStones = Int32.Parse(Console.ReadLine());
        if(numStones % 2 == 0)
        {
            Console.WriteLine("Bob");
        }
        else
        {
            Console.WriteLine("Alice");
        }
    }
}
