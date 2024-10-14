using System;

public class Program
{
    public static void Main(string[] args)
    {
        int numWords = Int32.Parse(Console.ReadLine());
        
        for(int i = 0; i < numWords; i++)
        {
            if(i % 2 == 0)
            {
                string newWord = Console.ReadLine();
                Console.WriteLine(newWord);
            }
            else
            {
                Console.ReadLine();
            }
        }
    }
}
