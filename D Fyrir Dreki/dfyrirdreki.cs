using System;

public class Program
{
    public static void Main(string[] args)
    {
        int a = Int32.Parse(Console.ReadLine());
        int b = Int32.Parse(Console.ReadLine());
        int c = Int32.Parse(Console.ReadLine());
        int d = (b * b) - (4 * a * c);
        if(d > 0)
        {
            Console.WriteLine("2");
        }
        else if(d == 0)
        {
            Console.WriteLine("1");
        }
        else
        {
            Console.WriteLine("0");
        }
    }
}
