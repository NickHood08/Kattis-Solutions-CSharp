using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n = Int32.Parse(Console.ReadLine());
        if(n % 2 == 0)
        {
            Console.WriteLine("second");
        }
        else
        {
            Console.WriteLine("first");
        }
    }
}
