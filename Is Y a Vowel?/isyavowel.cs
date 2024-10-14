using System;

public class Program
{
    public static void Main(string[] args)
    {
        string vowels = "aeiou";
        string word = Console.ReadLine();
        int vowelsWithoutY = 0;
        int vowelsWithY = 0;
        for(int i = 0; i < word.Length; i++)
        {
            char letter = word[i];
            if(vowels.Contains(letter))
            {
                vowelsWithoutY += 1;
                vowelsWithY += 1;
            }
            if(letter == 'y')
            {
                vowelsWithY += 1;
            }
        }
        Console.WriteLine(vowelsWithoutY + " " + vowelsWithY);
    }
}
