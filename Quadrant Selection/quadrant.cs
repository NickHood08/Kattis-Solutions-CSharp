using System;

public class Program
{
    public static void Main(string[] args)
    {
        int x = Int32.Parse(Console.ReadLine());
        int y = Int32.Parse(Console.ReadLine());
        
        if(x > 0 && y > 0)
        {
            Console.WriteLine("1");
        }
        else if(x < 0 && y > 0)
        {
            Console.WriteLine("2");
        }
        else if(x < 0 && y < 0)
        {
            Console.WriteLine("3");
        }
        else
        {
            Console.WriteLine("4");
        }
    }
}
