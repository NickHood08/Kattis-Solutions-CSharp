using System;

public class Program
{
    public static void Main(string[] args)
    {
        int numB = 0;
        int numK = 0;
        
        string word = Console.ReadLine();
        
        for(int i = 0; i < word.Length; i++)
        {
            if(word[i] == 'b')
            {
                numB += 1;
            }
            else if(word[i] == 'k')
            {
                numK += 1;
            }
        }
        
        if(numB > numK)
        {
            Console.WriteLine("boba");
        }
        else if(numB < numK)
        {
            Console.WriteLine("kiki");
        }
        else if(numB == numK && numB != 0)
        {
            Console.WriteLine("boki");
        }
        else
        {
            Console.WriteLine("none");
        }
    }
}
