using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string lowercaseLetters = "abcdefghijklmnopqrstuvwxyz";
        string uppercaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        int numLetters = 0;
        for(int i = 0; i < input.Length; i++)
        {
            if(lowercaseLetters.Contains(input[i]) || uppercaseLetters.Contains(input[i]))
            {
                numLetters += 1;
            }
        }
        Console.WriteLine(numLetters);
    }
}
