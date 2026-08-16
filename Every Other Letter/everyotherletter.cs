using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string newStr = string.Empty;
        
        for(int i = 0; i < input.Length; i+=2)
        {
            Console.Write(input[i]);
        }
    }
}
