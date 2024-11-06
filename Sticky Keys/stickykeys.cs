using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string final = string.Empty;
        char currentLetter = '*';
        
        final += input[0].ToString();
        currentLetter = input[0];
        
        for(int i = 1; i < input.Length; i++)
        {
            if(input[i] != currentLetter)
            {
                final += input[i].ToString();
                currentLetter = input[i];
            }
        }
        
        Console.WriteLine(final);
    }
}
