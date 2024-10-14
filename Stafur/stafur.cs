using System;

public class Program
{
    public static void Main(string[] args)
    {
        string vowels = "AEIOU";
        string letter = Console.ReadLine();
        if(vowels.Contains(letter))
        {
            Console.WriteLine("Jebb");
        }
        else if(letter == "Y")
        {
            Console.WriteLine("Kannski");
        }
        else
        {
            Console.WriteLine("Neibb");
        }
    }
}
