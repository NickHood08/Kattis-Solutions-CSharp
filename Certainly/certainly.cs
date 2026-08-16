using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string word = "certainly";
        
        int numCertainly = 0;
        int index = 0;
        
        while((index = input.IndexOf(word, index)) != -1)
        {
            numCertainly++;
            index += word.Length;
        }
        
        Console.WriteLine(numCertainly);
    }
}
