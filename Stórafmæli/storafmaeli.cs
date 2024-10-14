using System;

public class PartyPlanner
{
    public static void Main(string[] args)
    {
        int age = Int32.Parse(Console.ReadLine());
        if(age % 10 == 0)
        {
            Console.WriteLine("Jebb");
        }
        else
        {
            Console.WriteLine("Neibb");
        }
    }
}
