using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNumSwedish = Console.ReadLine();
        int numSwedish = Int32.Parse(strNumSwedish);
        string swedishSentence = Console.ReadLine();
        string[] swedishWords = swedishSentence.Split(" ");
        string[] translation = new string[numSwedish];
        string strNum = Console.ReadLine();
        int num = Int32.Parse(strNum);
        string finalSentence = string.Empty;
        for(int i = 0; i < num; i++)
        {
            string input = Console.ReadLine();
            string swedWord = input.Split(" ")[0];
            string engWord = input.Split(" ")[1];
            for(int j = 0; j < swedishWords.Length; j++)
            {
                if(swedishWords[j] == swedWord)
                {
                    translation[j] = engWord;
                }
            }
        }
        
        for(int i = 0; i < translation.Length; i++)
        {
            finalSentence += translation[i] + " ";
        }
        finalSentence.Trim();
        Console.WriteLine(finalSentence);
    }
}
