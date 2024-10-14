using System;

public class Reduplication
{
    public static void Main(string[] args)
    {
        string word = Console.ReadLine();
        int timesToWrite = Int32.Parse(Console.ReadLine());
        
        for(int i = 0; i < timesToWrite; i++)
        {
            Console.Write(word);
        }
    }
}
