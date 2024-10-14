using System;

public class Program
{
    public static void Main(string[] args)
    {
        string wordStart = Console.ReadLine();
        string wordEnd = Console.ReadLine();
        int numPeople = 1;
        for(int i = 0; i < wordStart.Length; i++)
        {
            if(wordStart[i] != wordEnd[i])
            {
                numPeople += 1;
            }
        }
        Console.WriteLine(numPeople);
    }
}
