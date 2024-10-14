using System;

public class Program
{
    public static void Main(string[] args)
    {
        string word = Console.ReadLine();
        string guess = Console.ReadLine();
        int limit = 0;
        for(int i = 0; i < guess.Length; i++)
        {
            if(word.Contains(guess[i].ToString()))
            {
                word = word.Replace(guess[i].ToString(), "");
            }
            else
            {
                limit += 1;
            }
            if(limit == 10 || word.Length == 0)
            {
                break;
            }
        }
        
        if(word.Length == 0)
        {
            Console.WriteLine("WIN");
        }
        else if(limit == 10)
        {
            Console.WriteLine("LOSE");
        }
    }
}
