using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        char currentLetter = 'A';
        char tempLetter = '!';
        for(int i = 0; i < input.Length; i++)
        {
            tempLetter = input[i];
            if(tempLetter != currentLetter)
            {
                currentLetter = tempLetter;
                Console.Write(tempLetter);
            }
        }
        
    }
}
