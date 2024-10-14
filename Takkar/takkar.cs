using System;

public class Program
{
    public static void Main(string[] args)
    {
        int trumpSize = Int32.Parse(Console.ReadLine());
        int kimSize = Int32.Parse(Console.ReadLine());
        
        if(trumpSize > kimSize)
        {
            Console.WriteLine("MAGA!");
        }
        else if(kimSize > trumpSize)
        {
            Console.WriteLine("FAKE NEWS!");
        }
        else {
            Console.WriteLine("WORLD WAR 3!");
        }
    }
}
