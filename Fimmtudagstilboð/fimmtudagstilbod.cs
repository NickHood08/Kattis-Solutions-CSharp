using System;

public class Program
{
    public static void Main(string[] args)
    {
        int year = Int32.Parse(Console.ReadLine());
        if(year < 2020)
        {
            Console.WriteLine(1000);
        }
        else
        {
            Console.WriteLine(1000 + ((year - 2020) * 100));
        }
    }
}
