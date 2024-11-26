using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNum = Console.ReadLine();
        string needle = Console.ReadLine();
        string haystack = Console.ReadLine();
        
        if(haystack.Contains(needle))
        {
            Console.WriteLine("Unnar fann hana!");
        }
        else
        {
            Console.WriteLine("Unnar fann hana ekki!");
        }
    }
}
