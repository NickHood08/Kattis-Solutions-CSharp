using System;

public class Program
{
    public static void Main(string[] args)
    {
        string dna = Console.ReadLine();
        if(dna.Contains("COV"))
        {
            Console.WriteLine("Veikur!");
        }
        else
        {
            Console.WriteLine("Ekki veikur!");
        }
    }
}
