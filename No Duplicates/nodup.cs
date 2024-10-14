using System;

public class Program
{
    public static void Main(string[] args)
    {
        string phrase = Console.ReadLine();
        string[] allWords = phrase.Split(" ");
        bool repeats = false;
        for(int i = 0; i < allWords.Length - 1; i++)
        {
            for(int j = i + 1; j < allWords.Length; j++)
            {
                if(allWords[i] == allWords[j])
                {
                    repeats = true;
                    break;
                }
            }
        }
        if(repeats)
        {
            Console.WriteLine("no");
        }
        else
        {
            Console.WriteLine("yes");
        }
    }
}
