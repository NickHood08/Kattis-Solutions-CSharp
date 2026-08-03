using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        char[] inputCharArray = input.ToCharArray();
        Array.Reverse(inputCharArray);
        string reversedInput = new string(inputCharArray);
        
        if(input == reversedInput)
        {
            Console.WriteLine("Palindrome!");
        }
        else
        {
            Console.WriteLine("Nothing special about this string :(");
        }
    }
}
