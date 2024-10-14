using System;

public class Program
{
    public static void Main(string[] args)
    {
        string name = Console.ReadLine();
        int age = Int32.Parse(Console.ReadLine());
        
        for(int i = 0; i < age; i++)
        {
            Console.WriteLine("Hipp hipp hurra, " + name + "!");
        }
    }
}
