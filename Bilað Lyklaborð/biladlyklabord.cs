using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string currentLetter = string.Empty;
        string newString = string.Empty;
        for(int i = 0; i < input.Length; i++)
        {
            if(input[i].ToString() != currentLetter)
            {
                newString += input[i].ToString();
                currentLetter = input[i].ToString();
            }
        }
        Console.WriteLine(newString);
    }
}
