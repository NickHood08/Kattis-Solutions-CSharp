using System;

public class Program
{
    public static void Main(string[] args)
    {
        string vowels = "aeiou";
        string input = Console.ReadLine();
        int totalVowels = 0;
        for(int i = 0; i < input.Length; i++)
        {
            if(vowels.Contains(input[i].ToString().ToLower()))
            {
                totalVowels += 1;
            }
        }
        Console.WriteLine(totalVowels);
    }
}
