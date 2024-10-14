using System;

public class Program
{
    public static void Main(string[] args)
    {
        string ah1 = Console.ReadLine();
        string ah2 = Console.ReadLine();
        if(ah2.Length <= ah1.Length)
        {
            Console.WriteLine("go");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
