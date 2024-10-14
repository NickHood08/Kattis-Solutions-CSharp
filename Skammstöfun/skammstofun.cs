using System;

public class Program
{
    public static void Main(string[] args)
    {
        string capitals = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        int numWords = Int32.Parse(Console.ReadLine());
        string strWords = Console.ReadLine();
        string[] wordsArray = strWords.Split(" ");
        for(int i = 0; i < wordsArray.Length; i++)
        {
            if(capitals.Contains(wordsArray[i].Substring(0,1)))
            {
                Console.Write(wordsArray[i].Substring(0,1));
            }
        }
    }
}
